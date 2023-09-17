namespace MyWebApiApp.Models
{
	public class HangHoaVM
	{
        public string tenHangHoa { get; set; }
        public double donGia { get; set; }
    }
	public class HangHoa : HangHoaVM
	{
        public Guid MaHangHoa { get; set; }
    }
}
