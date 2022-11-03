using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_class;
using NUnit.Framework;
namespace oop_class_test
{
    [TestFixture]
    public class Class_test
    {
        /// </summary>
        [TestCase]
        public void test_student()
        {
            student s = new student();
            s.student_id = 11;
            s.student_name = "Gayathri";
            Assert.AreEqual(s.student_id, 11);
        }
        [TestCase]
        public void test_subject()
        {
            subject s = new subject();
            s.subject_id = 12;
            s.subject_name = "physics";
            s.subject_marks = 100;
            Assert.AreEqual(s.subject_marks, 100);
        }
        [TestCase]
        public void test_teacher()
        {
            teacher s = new teacher();
            s.teacher_id = 13;
            s.teacher_name = "Lakshmi";
            Assert.AreEqual(s.teacher_name, "Lakshmi");
        }

    }
}
