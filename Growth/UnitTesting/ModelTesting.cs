using Xunit;
using GrowthModels;

namespace UnitTesting
{
    public class ModelTesting
    {
        [Fact]
        public void UserTest1()
        {
            UserAccount nu = new UserAccount();

            nu.Username = "JD";
            nu.Password = "153246";
            nu.Email = "JD.Saxton@gmail.com";

            Assert.Equal("JD", nu.Username);
            Assert.Equal("153246", nu.Password);
            Assert.Equal("JD.Saxton@gmail.com", nu.Email);
        }

        [Fact]
        public void UserTest2()
        {
            UserAccount nu = new UserAccount();

            nu.Username = "DonMomotaro";
            nu.Password = "11111";
            nu.Email = "donmomo@gmail.com";
            nu.PhoneNumber = "111-222-3333";

            Assert.Equal("DonMomotaro", nu.Username);
            Assert.Equal("11111", nu.Password);
            Assert.Equal("donmomo@gmail.com", nu.Email);
            Assert.Equal("111-222-3333", nu.PhoneNumber);
        }

        [Fact]
        public void UserTest3()
        {
            UserAccount nu = new UserAccount();

            nu.Username = "SaruBrother";
            nu.Password = "22222";
            nu.Email = "sarubro@gmail.com";

            Assert.Equal("SaruBrother", nu.Username);
            Assert.Equal("22222", nu.Password);
            Assert.Equal("sarubro@gmail.com", nu.Email);
        }

        [Fact]
        public void GoalsTest1()
        {
            Goals goal1 = new Goals();

            goal1.GoalName = "Get Swole";
            goal1.Description = "I'm trying to get swole";
            goal1.Habit1 = "Eat right";
            goal1.Habit2 = "Lift heavy";
            goal1.Habit3 = "Cry later";

            Assert.Equal("Get Swole", goal1.GoalName);
            Assert.Equal("I'm trying to get swole", goal1.Description);
            Assert.Equal("Eat right", goal1.Habit1);
            Assert.Equal("Lift heavy", goal1.Habit2);
            Assert.Equal("Cry later", goal1.Habit3);
        }

        [Fact]
        public void GoalsTest2()
        {
            Goals goal2 = new Goals();

            goal2.GoalName = "Triathlon";
            goal2.Description = "Preparing for the triathlon";
            goal2.Habit1 = "Spin cylcing";
            goal2.Habit2 = "More cardio";
            goal2.Habit3 = "Bike five miles";

            Assert.Equal("Triathlon", goal2.GoalName);
            Assert.Equal("Preparing for the triathlon", goal2.Description);
            Assert.Equal("Spin cylcing", goal2.Habit1);
            Assert.Equal("More cardio", goal2.Habit2);
            Assert.Equal("Bike five miles", goal2.Habit3);
        }

        [Fact]
        public void GoalsTest3()
        {
           Goals goal3 = new Goals();

            goal3.GoalName = "Summer Bod";
            goal3.Description = "Let's get in shape for bikini season";
            goal3.Habit1 = "Cardio";
            goal3.Habit2 = "Eat more greens, less carbs";
            goal3.Habit3 = "Drink Protein Shakes";

            Assert.Equal("Summer Bod", goal3.GoalName);
            Assert.Equal("Let's get in shape for bikini season", goal3.Description);
            Assert.Equal("Cardio", goal3.Habit1);
            Assert.Equal("Eat more greens, less carbs", goal3.Habit2);
            Assert.Equal("Drink Protein Shakes", goal3.Habit3);
        }

        [Fact]
        public void HealthProfileTest1()
        {
            HealthProfile hp1 = new HealthProfile();

            hp1.Username = "DonMomotaro";
            hp1.Weight = 236;
            hp1.Height = "5'6";
            hp1.CurrentDate = "05/30/2022";

            Assert.Equal("DonMomotaro", hp1.Username);
            Assert.Equal(236, hp1.Weight);
            Assert.Equal("5'6", hp1.Height);
            Assert.Equal("05/30/2022", hp1.CurrentDate);
        }

        [Fact]
        public void HealthProfileTest2()
        {
            HealthProfile hp2 = new HealthProfile();

            hp2.Username = "DonDoragoku";
            hp2.Weight = 120;
            hp2.Height = "6'4";
            hp2.CurrentDate = "05/30/2022";

            Assert.Equal("DonDoragoku", hp2.Username);
            Assert.Equal(120, hp2.Weight);
            Assert.Equal("6'4", hp2.Height);
            Assert.Equal("05/30/2022", hp2.CurrentDate);
        }

        [Fact]
        public void HealthProfileTest3()
        {
            HealthProfile hp3 = new HealthProfile();

            hp3.Username = "SaruBrother";
            hp3.Weight = 463;
            hp3.Height = "7'6";
            hp3.CurrentDate = "05/30/2022";

            Assert.Equal("SaruBrother", hp3.Username);
            Assert.Equal(463, hp3.Weight);
            Assert.Equal("7'6", hp3.Height);
            Assert.Equal("05/30/2022", hp3.CurrentDate);
        }
    }
}