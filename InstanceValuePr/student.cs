namespace MyApp
{
    internal class student
    {
        internal string name;
        internal int grade;

        public override string ToString()
        {
            return this.grade + "학년 " + this.name;
        }
    }
}