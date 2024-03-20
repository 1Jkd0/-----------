using NUnit.Framework;
using Groups.Implementions;
using Students.Implementations;

namespace Tests
{
    public class AllEntitiesTests
    {
        [Test]
        public void TestGroupEntity()
        {
            // Arrange
            GroupEntity group = new GroupEntity("TestGroup");

            // Act
            group.AddMemberAtomically();
            group.AddMemberAtomically();

            // Assert
            Assert.AreEqual(2, group.MemberCount);
        }

        [Test]
        public void TestGroupManagerEntity()
        {
            // Arrange
            GroupManagerEntity groupManager = new GroupManagerEntity();

            // Act
            groupManager.CreateGroup("TestGroup1");
            groupManager.CreateGroup("TestGroup2");

            // Assert
            Assert.IsTrue(groupManager.GroupExists("TestGroup1"));
            Assert.IsTrue(groupManager.GroupExists("TestGroup2"));
        }

        [Test]
        public void TestPersonEntity()
        {
            // Arrange
            PersonEntity person = new PersonEntity("John Doe", 30);

            // Assert
            Assert.AreEqual("John Doe", person.Name);
            Assert.AreEqual(30, person.Age);
        }

        [Test]
        public void TestStudentEntity()
        {
            // Arrange
            StudentEntity student = new StudentEntity("Alice Smith", 20, "123456");

            // Assert
            Assert.AreEqual("Alice Smith", student.Name);
            Assert.AreEqual(20, student.Age);
            Assert.AreEqual("123456", student.StudentId);
        }

        [Test]
        public void TestSubjectEntity()
        {
            // Arrange
            SubjectEntity subject = new SubjectEntity("Math", "MATH101");

            // Assert
            Assert.AreEqual("Math", subject.Name);
            Assert.AreEqual("MATH101", subject.Code);
        }

        [Test]
        public void TestTeacherEntity()
        {
            // Arrange
            TeacherEntity teacher = new TeacherEntity("Jane Doe", 35, "Math");

            // Assert
            Assert.AreEqual("Jane Doe", teacher.Name);
            Assert.AreEqual(35, teacher.Age);
            Assert.AreEqual("Math", teacher.Subject);
        }
    }
}

