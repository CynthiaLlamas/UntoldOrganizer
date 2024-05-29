public class Episode {
    Series? series {get;set;}
    string? episodeTitle {get;set;}
    int seasonNumber {get;set;}
    int episodeNumber {get;set;}
    public Setting episodeSetting {get;set;}
    public EpisodeSynopis episodeSynopis {get;set;}
    public EpisodeNotes episodeNotes {get;set;}
}
public class Setting {
    string? settingTime {get;set;}
    string? settingPlace {get;set;}
    string? settingKnowledge {get;set;}
    string? tone {get;set;}
    string? settingSynopsis {get;set;}
}
public class EpisodeSynopis{
    string? episodeImpact {get;set;}
    List<string>? looseEnds;
    List<string>? plotHooks;
}
public class EpisodeNotes {
    List<string>? importantCharacters = new List<string>();
    List<string>? importantPlaces = new List<string>();
    List<string>? importantItems = new List<string>();
    string? other {get;set;}
}