using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp11
{
    public class Enrolments
    {
        public Dictionary<string, Student> students;

        public event voidNoArgs ReadEnded;
        public event voidNoArgs WriteEnded;
        public event voidNoArgs EnrolmentsUpdated;

        public Enrolments()
        {
            students = new Dictionary<string, Student>();
        }

        public void ReadFromTXT(string file)
        {
            students.Clear();

            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] StudentData = line.Split(";");

                Student student = new Student(StudentData[0], StudentData[1], StudentData[2]);

                if (StudentData[3] == "Inscrito")
                    student.Subscribed = true;
                else
                    student.Subscribed = false;

                students.Add(student.Number, student);
            }
            sr.Close();

            if (ReadEnded != null)
                ReadEnded();
        }

        public void WriteToTXT(string file)
        {
            if (students.Count == 0)
                throw new InvalidOperationException("Nao existem dados para serem guardados!");

            StreamWriter sw = new StreamWriter(file);
            foreach (Student student in students.Values)
            {
                string line = student.Number + ";" + student.Name + ";" + student.Course + ";";
                if (student.Subscribed == true)
                    line += "Inscrito";
                else
                    line += "NaoInscrito";
                sw.WriteLine(line);
            }
            sw.Close();

            if (WriteEnded != null)
                WriteEnded();
        }

        public void ChangeSubscrition(string number)
        {
            Student student;
            students.TryGetValue(number, out student);

            if (student != null)
            {
                student.Subscribed = !student.Subscribed;

                if (EnrolmentsUpdated != null)
                    EnrolmentsUpdated();
            }
        }
    }
}
