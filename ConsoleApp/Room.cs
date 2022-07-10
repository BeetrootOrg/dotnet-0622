namespace ConsoleApp.School;

class Room
{
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public char Floor;
    private SchoolStaff[] responsible { get; set; }

    private SchoolStaff[] AddRoomResponsible(SchoolStaff staff)
    {
        throw new NotImplementedException();
    }
}