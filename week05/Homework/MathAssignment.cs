using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string _textbookSection, string _problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }

}