using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using GoalTask.Data.DataAccess;
using GoalTask.Service;
using GoalTask.Data.DataModel;

namespace GoalTask.Service.Tests
{
    [TestFixture]
   public class TaskServiceTests
    {

        Mock<ITaskAccess> mockTaskAccess = new Mock<ITaskAccess>();
        TaskService taskService = new TaskService();
        
        [Test]
        public void AddTaskTest()
        {
            //Arrange
            mockTaskAccess.Setup(x => x.AddTask(It.IsAny<TaskModel>()));
            taskService.TaskAccess = mockTaskAccess.Object;

            //Act
            taskService.AddTask(new TaskModel());

            //Assert
            mockTaskAccess.VerifyAll();
        }

        [Test]
        public void UpdateTaskTest()
        {
            mockTaskAccess.Setup(x => x.UpdateTask(It.IsAny<TaskModel>()));
            taskService.TaskAccess = mockTaskAccess.Object;

            //Act
            taskService.UpdateTask(new TaskModel());

            //Assert
            mockTaskAccess.VerifyAll();

        }

        [Test]
        public void DeleteTaskTest()
        {
            mockTaskAccess.Setup(x => x.DeleteTask(It.IsAny<int>()));
            taskService.TaskAccess = mockTaskAccess.Object;

            //Act
            taskService.DeleteTask(1);

            //Assert
            mockTaskAccess.VerifyAll();

        }
    }
}
