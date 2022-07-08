namespace ConsoleApp.SchoolHW;

class Room
{
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public char Floor 
    {
        get => RoomNumber.ToString()[0];
    }

}