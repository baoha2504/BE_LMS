using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMS_IMAGE.Entities;
using LMS_API.Support;
namespace LMS_IMAGE.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FileBaiGiangController : ControllerBase
    {
        LMSContext _context = new LMSContext();
        private readonly IHostEnvironment _hostEnvironment;

        public FileBaiGiangController(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        [HttpPost]
        [Route("PostFile/{codemonhoc}/{tenbaigiang}")]
        public async Task<string> PostFile(string codemonhoc, string tenbaigiang, IFormFile file)
        {
            try
            {
                if(file.Length > 0)
                {
                    long fileSizeLimit = 100 * 1024 * 1024; // 100MB
                    if (file.Length > fileSizeLimit)
                    {
                        return "Kích thước tệp vượt quá 100MB. Vui lòng chọn tệp nhỏ hơn.";
                    }
                    string fileExtension = Path.GetExtension(file.FileName).ToLower();

                    List<string> allowedExtensions = new List<string> { ".pdf", ".docx", ".doc", ".xlsx", ".xls" };

                    if (!allowedExtensions.Contains(fileExtension))
                    {
                        return "Tệp tin không hợp lệ. Chỉ chấp nhận tệp tin PDF, DOCX, DOC, XLSX, và XLS.";
                    }


                    var monhoc = _context.MonHocs.SingleOrDefault(x => x.Code == codemonhoc);
                    if (monhoc == null)
                    {
                        return "Khong tim thay mon hoc thich hop";
                    }

                    string webRootPath = _hostEnvironment.ContentRootPath;
                    string folderPath = Path.Combine(webRootPath, "wwwroot/Upload", "FileBaiGiang");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                  
                    string filename = $"{tenbaigiang}_{DateTime.Now.ToString("yyyyMMddHHmmss")}{fileExtension}";
                    var filePath = Path.Combine(folderPath, filename) ;
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    monhoc.TenGiaotrinh = filename;
                    monhoc.FileGiaotrinh = filePath;
                    _context.SaveChanges();

                    return "Upload file thành công";
                }
                else
                {
                    return "File không phù hợp";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }

        [HttpPut]
        [Route("UpdateFile/{codemonhoc}/{tenbaigiang}")]
        public async Task<string> UpdateFile(string codemonhoc, string tenbaigiang, IFormFile file)
        {
            try
            {
                if (file.Length > 0)
                {
                    long fileSizeLimit = 100 * 1024 * 1024; // 100MB
                    if (file.Length > fileSizeLimit)
                    {
                        return "Kích thước tệp vượt quá 100MB. Vui lòng chọn tệp nhỏ hơn.";
                    }
                    string fileExtension = Path.GetExtension(file.FileName).ToLower();

                    List<string> allowedExtensions = new List<string> { ".pdf", ".docx", ".doc", ".xlsx", ".xls" };

                    if (!allowedExtensions.Contains(fileExtension))
                    {
                        return "Tệp tin không hợp lệ. Chỉ chấp nhận tệp tin PDF, DOCX, DOC, XLSX, và XLS.";
                    }

                    var monhoc = _context.MonHocs.SingleOrDefault(x => x.Code == codemonhoc);
                    if (monhoc == null)
                    {
                        return "Khong tim thay mon hoc thich hop";
                    }

                    string webRootPath = _hostEnvironment.ContentRootPath;
                    string folderPath = Path.Combine(webRootPath, "wwwroot/Upload", "FileBaiGiang");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string[] filesInFolder = Directory.GetFiles(folderPath, "*.*"); // Get all files in the folder
                    foreach (string files in filesInFolder)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(files);
                        if (fileName.Contains(tenbaigiang))
                        {
                            System.IO.File.Delete(files);
                        }
                    }
                    string filename = $"{tenbaigiang}_{DateTime.Now.ToString("yyyyMMddHHmmss")}{fileExtension}";
                    var filePath = Path.Combine(folderPath, filename);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    monhoc.TenGiaotrinh = filename;
                    monhoc.FileGiaotrinh = filePath;
                    _context.SaveChanges();

                    return "Update file thành công";
                }
                else
                {
                    return "File không phù hợp";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }

        [HttpDelete]
        [Route("Delete/filebaigiang/{codemonhoc}")]
        public async Task<string> Deletebaigiang(string codemonhoc)
        {
            var monhoc = _context.MonHocs.SingleOrDefault(x => x.Code == codemonhoc);
            if (monhoc == null)
            {
                return "Khong tim thay mon hoc thich hop";
            }
            string webRootPath = _hostEnvironment.ContentRootPath;
            string folderPath = Path.Combine(webRootPath, "wwwroot/Upload", "FileBaiGiang");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            List<string> allowedExtensions = new List<string> { ".pdf", ".docx" };

            bool fileDeleted = false;

            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                string fileName = Path.GetFileName(filePath);
                string fileExtension = Path.GetExtension(fileName).ToLower();

                if (allowedExtensions.Contains(fileExtension) && fileName.Contains(monhoc.FileGiaotrinh))
                {
                    System.IO.File.Delete(filePath);
                    fileDeleted = true;
                }
            }

            if (fileDeleted)
            {
                monhoc.FileGiaotrinh = null;
                monhoc.TenGiaotrinh = null;

                _context.SaveChanges();
                return "Xóa file thành công.";
            }
            else
            {
                return "File không tồn tại.";
            }
        }

    }
}
