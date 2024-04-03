namespace LoanManagementSys;

public class Member
{
    private int id;
    private String name;

    public Member(int id, String name)
    {
        this.id = id;
        this.name = name;
    }

    public int ID
    {
        get { return id; }
        set { id = value; }

    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return $"{name}, ID {id}";
    }
}
