using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GoalTask.Data.DataModel;
using GoalTask.Service;
using GoalTask.Data.DataAccess;
using Moq;

namespace GoalTask.Service.Tests
{
    [TestFixture]
    public class GoalServiceTests
    {
        Mock<IGoalAccess> mockGoalAccess = new Mock<IGoalAccess>();
        GoalService goalService = new GoalService();

        [Test]
        public void AddGoalTest()
        {

            //Arrange
            mockGoalAccess.Setup(x => x.AddGoal(It.IsAny<GoalModel>()));
            goalService.GoalAccess = mockGoalAccess.Object;

            //Act
            goalService.AddGoal(new GoalModel());
            
            //Assert
            mockGoalAccess.VerifyAll();
            
        }

        [Test]
        public void UpdateGoalTest()
        {
            //Arrange
            mockGoalAccess.Setup(x => x.UpdateGoal(It.IsAny<GoalModel>()));
            goalService.GoalAccess = mockGoalAccess.Object;

            //Act
            goalService.UpdateGoal(new GoalModel());

            //Assert
            mockGoalAccess.VerifyAll();

        }

        [Test]
        public void DeleteGoalTest()
        {
            //Arrange
            mockGoalAccess.Setup(x => x.DeleteGoal(It.IsAny<int>()));
            goalService.GoalAccess = mockGoalAccess.Object;

            //Act
            goalService.DeleteGoal(1);

            //Assert
            mockGoalAccess.VerifyAll();

        }

        [Test]
        public void CloseGoalTest()
        {
            //Arrange
            mockGoalAccess.Setup(x => x.CloseGoal(It.IsAny<DateTime>(), It.IsAny<int>())).Returns(true);
            goalService.GoalAccess = mockGoalAccess.Object;

            //Act
            goalService.CloseGoal(DateTime.Now, 1);

            //Assert
            mockGoalAccess.VerifyAll();
        }
    }
}
