using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;

namespace LMS_IMAGE.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ImageController : ControllerBase
    {
        private readonly IHostEnvironment _hostEnvironment;

        public ImageController(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }


        //upload ảnh student
        [HttpPost]
        [Route("PostImageStudent")]
        public async Task<string> PostImageStudent(IFormFile imagefile)
        {
            try
            {
                if (imagefile.Length > 0)
                {
                    string webRootPath = _hostEnvironment.ContentRootPath;
                    string folderPath = Path.Combine(webRootPath, "wwwroot/Upload", "Image", "ImageStudent");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string filePath = Path.Combine(folderPath, imagefile.FileName);

                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }

                    using (FileStream filestream = System.IO.File.Create(filePath))
                    {
                        imagefile.CopyTo(filestream);
                        filestream.Flush();

                    }
                    return "Upload thành công";
                }
                else
                {
                    return "Lỗi ảnh!!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        [HttpGet("Upload/Image/ImageStudent/{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            imageName = imageName + ".jpg";
            string webRootPath = _hostEnvironment.ContentRootPath;
            string imagePath = Path.Combine(webRootPath, "wwwroot/Upload/Image/ImageStudent", imageName);

            if (System.IO.File.Exists(imagePath))
            {
                byte[] imageData = System.IO.File.ReadAllBytes(imagePath);
                return new FileContentResult(imageData, "image/jpeg");
            }
            else
            {
                return NotFound("Hình ảnh không tồn tại.");
            }
        }

        [HttpDelete]
        [Route("Delete/ImageStudent/{imageName}")]
        public IActionResult DeleteImageStudent(string imageName)
        {
            imageName = imageName + ".jpg";
            string webRootPath = _hostEnvironment.ContentRootPath;
            string imagePath = Path.Combine(webRootPath, "wwwroot/Upload/Image/ImageStudent", imageName);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                string defaultImageName = "defaultAvatar.jpg";
                string defaultImagePath = Path.Combine(webRootPath, "wwwroot/Upload/Image/", defaultImageName);
                if (System.IO.File.Exists(defaultImagePath))
                {
                    System.IO.File.Copy(defaultImagePath, imagePath, true);

                    return Ok("Xóa và thay thế ảnh thành công.");
                }
                else
                {
                    return NotFound("Không tìm thấy ảnh mặc định.");
                }
            }
            else
            {
                return NotFound("Hình ảnh không tồn tại.");
            }
        }
    }
}