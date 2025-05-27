public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public ScriptureLibrary()
    {
        SetLibrary();
    }

    private void SetLibrary()
    {
        _scriptures.Add(new Scripture(
            new Reference("1 Nephi", 14, 10),
            "And he said unto me: Behold there are save two churches only; " +
            "the one is the church of the Lamb of God, and the other is the church of the devil; " +
            "wherefore, whoso belongeth not to the church of the Lamb of God belongeth to that " +
            "great church, which is the mother of abominations; and she is the whore of all the earth."
        ));

        _scriptures.Add(new Scripture(
            new Reference("2 Nephi", 25, 23),
           "For we labor diligently to write, to persuade our children, " +
           "and also our brethren, to believe in Christ, and to be reconciled to God; " +
           "for we know that it is by grace that we are saved, after all we can do."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Alma", 11, 26, 29),
            "And Zeezrom said unto him: Thou sayest there is a true and living God? " +
            "And Amulek said: Yea, there is a true and living God. Now Zeezrom said: " +
            "Is there more than one God? And he answered, No."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Alma", 5, 27, 30),
            "Have ye walked, keeping yourselves blameless before God? " +
            "Could ye say, if ye were called to die at this time, within yourselves, that ye have been sufficiently humble? " +
            "That your garments have been cleansed and made white through the blood of Christ, " +
            "who will come to redeem his people from their sins? " +
            "Behold, are ye stripped of pride? I say unto you, if ye are not ye are not prepared to meet God. " +
            "Behold ye must prepare quickly; for the kingdom of heaven is soon at hand, and such an one hath not eternal life. " +
            "Behold, I say, is there one among you who is not stripped of envy? " +
            "I say unto you that such an one is not prepared; and I would that he should prepare quickly, " +
            "for the hour is close at hand, and he knoweth not when the time shall come; for such an one is not found guiltless. " +
            "And again I say unto you, is there one among you that doth make a mock of his brother, or that heapeth upon him persecutions? " +
            "Wo unto such an one, for he is not prepared, and the time is at hand that he must repent or he cannot be saved!"
        ));

        _scriptures.Add(new Scripture(
            new Reference("Mormon", 9, 9),
            "For do we not read that God is the same yesterday, today, and forever, " +
            "and in him there is no variableness neither shadow of changing?"
        ));

    }
    public Scripture GetRandomScripture()
    {
        Random indexGenerator = new Random();
        int scriptureIndex = indexGenerator.Next(0, _scriptures.Count);
        return _scriptures[scriptureIndex];
    }
}