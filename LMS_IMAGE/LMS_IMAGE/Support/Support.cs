using SixLabors.ImageSharp.Formats.Jpeg;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace LMS_API.Support
{
    public class Support
    {
        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public string GetFileExtension(string s)
        {
            string[] Name_extension = s.Split('.');
            int countarray = Name_extension.Count();
            s = Name_extension[countarray - 1];
            return s;
        }

        public string GetIPv4InPC()
        {
            string hostName = Dns.GetHostName(); // Lấy tên máy tính
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName); // Lấy thông tin về máy tính
            string ip = "127.0.0.1";
            foreach (IPAddress ipAddress in hostEntry.AddressList)
            {
                if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip = ipAddress.ToString();
                }
            }
            return ip;
        }

        public bool CheckIsEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValidEmail = Regex.IsMatch(email, pattern);
            return isValidEmail;
        }

        public DateTime ConvertToDateTime(string input)
        {
            string format = "yyyy-MM-dd h:mm:ss:tt";

            if (DateTime.TryParseExact(input, format, null, System.Globalization.DateTimeStyles.None, out DateTime result))
            {
                return result;
            }
            else
            {
                return DateTime.Now;
            }
        }
        static bool IsRunningAsAdmin()
        {
            using (var identity = System.Security.Principal.WindowsIdentity.GetCurrent())
            {
                var principal = new System.Security.Principal.WindowsPrincipal(identity);
                return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
        }

        // Khởi động lại chương trình với quyền Administrator
        static void StartAsAdmin()
        {
            var startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = Environment.CurrentDirectory;
            startInfo.FileName = System.Reflection.Assembly.GetEntryAssembly().Location;
            startInfo.Verb = "runas"; // Khởi động lại với quyền Administrator

            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public async Task<string> CompressAndSaveImage(IFormFile imageFile, string filePath, Guid id)
        {
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" }; 

            var fileExtension = Path.GetExtension(imageFile.FileName).ToLower();

            if (!allowedExtensions.Contains(fileExtension))
            {
                return "Định dạng hình ảnh không được hỗ trợ";
            }

            var imagePath = Path.Combine(filePath, id.ToString())+".jpg";
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            using (var stream = new MemoryStream())
            {
                imageFile.CopyToAsync(stream);
                stream.Position = 0;

                using (var image = Image.Load(stream))
                {
                    int maxWidth = 1280;
                    int maxHeight = 720;
                    image.Mutate(x => x
                   .Resize(new ResizeOptions
                   {
                       Size = new Size(maxWidth, maxHeight),
                       Mode = ResizeMode.Pad
                   }));

                   
                    if (!IsRunningAsAdmin())
                    {
                        // Nếu không có quyền Administrator, khởi động lại chương trình với quyền Administrator
                        StartAsAdmin();

                    }
                    using (FileStream filestream = System.IO.File.Create(imagePath))
                    {
                        image.Save(filestream, new JpegEncoder());
                        /*  imageFile.CopyTo(filestream);
                          filestream.Flush();*/
                    }
                   
                    var filePathSQL = $"{id}" + ".jpg";
                    return filePathSQL;
                }
            }
        }

        public IFormFile? GetAvatar(string avatarPath)
        {
            if (string.IsNullOrWhiteSpace(avatarPath))
            {
                return null;
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(avatarPath);
            IFormFile avatarFile = new FormFile(new MemoryStream(fileBytes), 0, fileBytes.Length, null, Path.GetFileName(avatarPath));

            return avatarFile;
        }

       
    }
}
