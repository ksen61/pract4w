using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract44WPF
{
    public class TestClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public AnswerEnum Rightanswer { get; set; }

        public TestClass(string name, string description, string answer1, string answer2, string answer3, AnswerEnum rightanswer)
        {
            this.Name = name;
            this.Description = description;
            this.Answer1 = answer1;
            this.Answer2 = answer2;
            this.Answer3 = answer3;
            this.Rightanswer = rightanswer;
        }
    }

    public enum AnswerEnum
    {
        First, Second, Third
    }
}
