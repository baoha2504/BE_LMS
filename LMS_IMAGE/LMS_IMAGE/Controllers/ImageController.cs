using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;
using LMS_IMAGE.Entities;
using LMS_API.Support;

namespace LMS_IMAGE.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ImageController : ControllerBase
    {
        LMSContext _context = new LMSContext();
        Support support = new Support();
        private readonly IHostEnvironment _hostEnvironment;

        public ImageController(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }


        //upload ảnh student
        [HttpPost]
        [Route("PostImageStudent/{idstudent}")]
        public async Task<string> PostImageStudent(Guid idstudent, IFormFile imagefile)
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
                    var student = await _context.StudentLogins.SingleOrDefaultAsync(x => x.Id == idstudent);
                    if (student == null)
                    {
                        return "Không tìm thấy học sinh";
                    }
                    var imagePath = Path.Combine(folderPath, idstudent.ToString()) + ".jpg";
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    string filePathSQL = await support.CompressAndSaveImage(imagefile, folderPath, idstudent);
                    student.Avatar = filePathSQL;
                    _context.SaveChanges();

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

        [HttpDelete]
        [Route("Delete/ImageStudent/{idstudent}")]
        public async Task<string> DeleteImageStudent(string idstudent)
        {
            Guid id = Guid.Parse(idstudent);
            var studentlogin = _context.StudentLogins.SingleOrDefault(x => x.Id == id);
            if (studentlogin == null)
            {
                return "Không tìm thấy học sinh";
            }
            idstudent = idstudent + ".jpg";
            string webRootPath = _hostEnvironment.ContentRootPath;
            string imagePath = Path.Combine(webRootPath, "wwwroot/Upload/Image/ImageStudent", idstudent);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                studentlogin.Avatar = null;
                _context.SaveChanges();
                return "Xóa thành công."; 
            }
            else
            {
                return "Hình ảnh không tồn tại.";
            }
        }


        //upload ảnh office
        [HttpPost]
        [Route("PostImageOffice/{idstudent}")]
        public async Task<string> PostImageOffice(IFormFile imagefile, Guid idstudent)
        {
            try
            {
                if (imagefile.Length > 0)
                {
                    string webRootPath = _hostEnvironment.ContentRootPath;
                    string folderPath = Path.Combine(webRootPath, "wwwroot/Upload", "Image", "ImageOffice");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    var student = await _context.StudentInfos.SingleOrDefaultAsync(x => x.StudentId == idstudent);
                    if (student == null)
                    {
                        return "Không tìm thấy học sinh";
                    }
                    var imagePath = Path.Combine(folderPath, idstudent.ToString()) + ".jpg";
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    string filePathSQL = await support.CompressAndSaveImage(imagefile, folderPath, idstudent);
                    student.ImageOffice = filePathSQL;
                    _context.SaveChanges();

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

        [HttpDelete]
        [Route("Delete/ImageOffice/{idstudent}")]
        public async Task<string> DeleteImageOffice(string idstudent)
        {
            Guid id = Guid.Parse(idstudent);
            var student = _context.StudentInfos.SingleOrDefault(x => x.StudentId == id);
            if (student == null)
            {
                return "Không tìm thấy học sinh";
            }
            idstudent = idstudent + ".jpg";
            string webRootPath = _hostEnvironment.ContentRootPath;
            string imagePath = Path.Combine(webRootPath, "wwwroot/Upload/Image/ImageOffice", idstudent);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                student.ImageOffice = null;
                _context.SaveChanges();
                return "Xóa thành công.";
            }
            else
            {
                return "Hình ảnh không tồn tại.";
            }
        }

        //upload ảnh user
        [HttpPost]
        [Route("PostImageUser/{iduser}")]
        public async Task<string> PostImageUser(Guid iduser, IFormFile imagefile)
        {
            try
            {
                if (imagefile.Length > 0)
                {
                    string webRootPath = _hostEnvironment.ContentRootPath;
                    string folderPath = Path.Combine(webRootPath, "wwwroot/Upload", "Image", "ImageUser");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    var user = await _context.UserLogins.SingleOrDefaultAsync(x => x.Id == iduser);
                    if (user == null)
                    {
                        return "Không tìm thấy học sinh";
                    }
                    var imagePath = Path.Combine(folderPath, iduser.ToString()) + ".jpg";
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    string filePathSQL = await support.CompressAndSaveImage(imagefile, folderPath, iduser);
                    user.Avatar = filePathSQL;
                    _context.SaveChanges();

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

       

        [HttpDelete]
        [Route("Delete/ImageUser/{iduser}")]
        public async Task<string> DeleteImageUser(string iduser)
        {
            Guid id = Guid.Parse(iduser);
            var user = _context.UserLogins.SingleOrDefault(x => x.Id == id);
            if (user == null)
            {
                return "Không tìm thấy nguoi dung";
            }
            iduser = iduser + ".jpg";
            string webRootPath = _hostEnvironment.ContentRootPath;
            string imagePath = Path.Combine(webRootPath, "wwwroot/Upload/Image/ImageUser", iduser);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                user.Avatar = null;
                _context.SaveChanges();
                return "Xóa ảnh thành công.";
            }
            else
            {
                return "Hình ảnh không tồn tại.";
            }
        }


        //upload ảnh chatroom
        [HttpPost]
        [Route("PostImageChatRoom/{idroom}")]
        public async Task<string> PostImageChatRoom(Guid idroom, IFormFile file)
        {
            try
            {
                if (file.Length > 0)
                {
                    string webRootPath = _hostEnvironment.ContentRootPath;
                    string folderPath = Path.Combine(webRootPath, "wwwroot/Upload", "Image", "ImageChatRoom");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    var room = await _context.ChatRooms.SingleOrDefaultAsync(x => x.RoomId == idroom);
                    if (room == null)
                    {
                        return "Không tìm thấy phòng";
                    }
                    var filePath = Path.Combine(folderPath, idroom.ToString()) + ".jpg";
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                    string filePathSQL = await support.CompressAndSaveImage(file, folderPath, idroom);
                    room.Avatar = filePathSQL;
                    _context.SaveChanges();

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



        [HttpDelete]
        [Route("Delete/ImageChatRoom/{idroom}")]
        public async Task<string> DeleteImageChatRoom(string idroom)
        {
            Guid id = Guid.Parse(idroom);
            var room = _context.ChatRooms.SingleOrDefault(x => x.RoomId == id);
            if (room == null)
            {
                return "Không tìm thấy nguoi dung";
            }
            idroom = idroom + ".jpg";
            string webRootPath = _hostEnvironment.ContentRootPath;
            string imagePath = Path.Combine(webRootPath, "wwwroot/Upload/Image/ImageChatRoom", idroom);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                room.Avatar = null;
                _context.SaveChanges();
                return "Xóa ảnh thành công.";
            }
            else
            {
                return "Hình ảnh không tồn tại.";
            }
        }
    }
}