public class Character {
    // will be an image later 
    string? profile;
    public required string name {get;set;}
    public required string role {get;set;}
    public required string motivation {get;set;}
    Special[] startingSpecials = new Special[2];
    Special[] secondarySpecials = new Special[2];
    Special[] tertiarySpecials = new Special[2];
    public string?  iconicRole {get;set;}
    List<Episode> episodesIn = new List<Episode>();
}

public enum SpecialType{
    ABILITY, 
    ITEM, 
    EXPERTISE
}
public class Special {
    string name {get;set;}
    SpecialType type {get;set;}
    string description {get;set;}
    string status {get;set;}
}