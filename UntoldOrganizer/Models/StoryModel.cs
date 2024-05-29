public class Story{
    public DangerousDilemma dangerousDilemma {get;set;}
    public PlotThickens plotThickens {get;set;}
    public HeroicUndertaking heroicUndertaking {get;set;}
    public TruthRevealed truthRevealed {get;set;}
    public FinalShowdown finalShowdown {get;set;}
}
public enum Relations {
    THREAT,
    EACH_OTHER,
    NOUN
}
public enum SceneTerms {
    PURSUING,
    SOMEONE_OR_THING,
    ACCUSING,
    ATTACKING,
    CAPTURED,
    DARK_AGENDA,
    SECRET,
    EVIL_MASTER,
    EVIL_ALLY,
    SEEKING,
    TARGETING,
    YOU
}
public enum Outcome {
    POSAND,
    SUCCESS,
    POSBUT,
    NEGBUT,
    FAIL,
    NEGAND
}
public enum Reaction {
    SHOCKED,
    UNIMPRESSED,
    LOVE,
    SAD,
    LAUGH,
    PAIN,
    ANGER,
    EMBARRESSED,
    SMUG,
    SCARED
}
public class BeatSetUp{
    public string location {get;set;}
    public string threat {get;set;}
    public SceneTerms verb {get;set;}
    public Relations verbIsRelatedTo {get;set;}
    public SceneTerms noun {get;set;}
}
public class BeatResolution {
    SceneTerms plot {get;set;}
    Relations connectsTo {get;set;}
}
public class Action {
    public required string action {get;set;}
    public required Outcome outcome {get;set;}
    public Reaction reaction {get;set;}
    public required string description {get;set;}
}
public class Question {
    public required string question {get;set;}
    public required string answer {get;set;}
}
public class DangerousDilemma : BeatSetUp{
    Question[] questions = new Question[4];
    Action[] actions = new Action[4];
    public void addQuestion(Question question){
        int index = questions.Count();
        questions[index] = question;
    }
    public void addActions(Action action){
        int index = actions.Count();
        actions[index] =action;
    }
}
public class PlotThickens :BeatResolution {
    Question[] questions = new Question[3];
    public void addQuestion(Question question){
        int index = questions.Count();
        questions[index] = question;
    }
}
public class HeroicUndertaking :BeatSetUp {
    Question[] questions = new Question[2];
    Action[] actions = new Action[4];
    public void addQuestion(Question question){
        int index = questions.Count();
        questions[index] = question;
    }
    public void addActions(Action action){
        int index = actions.Count();
        actions[index] =action;
    }
}
public class TruthRevealed :BeatResolution {
    Question[] questions = new Question[1];
    public void addQuestion(Question question){
        questions[0] = question;
    }
}
public class FinalShowdown {
    public string location {get;set;}
    public string threat1 {get;set;}
    public string threat2 {get;set;}
    public SceneTerms verb1 {get;set;}
    public Relations relation1 {get;set;}
    public SceneTerms verb2 {get;set;}
    public Relations relation2 {get;set;}
    public SceneTerms noun {get;set;}
    Action[] actions = new Action[6];
    public void addActions(Action action){
        int index = actions.Count();
        actions[index] =action;
    }
}