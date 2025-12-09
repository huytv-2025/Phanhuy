namespace FaceID.Models
{
    public class UserFace
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string FaceDescriptor { get; set; } = null!; // 128 float, lưu dạng chuỗi
        public DateTime CreatedAt { get; set; }
    }
}
