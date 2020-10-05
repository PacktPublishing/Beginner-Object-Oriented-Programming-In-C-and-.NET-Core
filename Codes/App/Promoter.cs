using System;

public abstract class Promoter
{
    private string _firstName;
    private string _lastName;
    private long _cellPhone;

    public string MyBusinessCard
    {
        get
        {
            return String.Format("{0} {1} {2}.", this._firstName, this._lastName, this._cellPhone);        
        }
    }

    public Promoter(string firstName, string lastName, long cellPhone)
    {   
        this._firstName = firstName;
        this._lastName = lastName;
        this._cellPhone = cellPhone;
    }



    public void Promote()
    {
        this.ShareWithInnerCircle();
        this.UsePaidAds();
    }

    protected abstract void ShareWithInnerCircle();
    protected abstract void UsePaidAds();
}