using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("The grade cannot be negative.");
        }

        if (minGrade < 0)
        {
            throw new ArgumentException("Minimal grade cannot be negative.");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Maximum grade cannot be larger or equal to minimum grade.");
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentException("Comments cannot be null or empty.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}