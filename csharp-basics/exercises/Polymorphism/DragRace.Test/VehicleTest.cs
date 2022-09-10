using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Test;

[TestClass]
public class VehicleTest
{
    private Vehicle _vehicle;
    private Toyota _toyota;

    [TestInitialize]
    public void Setup()
    {
        _vehicle = new Vehicle();
        _toyota = new Toyota();
    }
    
    [TestMethod]
    public void VehicleSpeedUp_SpeedsUpByrandomNumber()
    {
        //Act
        _vehicle.SpeedUp();

        //Assert
        _vehicle.Speed.Should().BeInRange(10,40);
    }

    [TestMethod]
    public void VehicleSlowDown_SlowDownByRandomNumber()
    {
        //Act
        _vehicle.SpeedUp();
        _vehicle.SlowDown();

        //Assert
        _vehicle.Speed.Should().BeInRange(0, 30);
    }

    [TestMethod]
    public void ShowCurrentSpeed_VehicleStartEngine_VehicleNotMoving()
    {
        //Act
        _vehicle.StartEngine();

        //Assert
        _vehicle.ShowCurrentSpeed.Should().Be("0");
    }

    [TestMethod]
    public void ShowCurrentSpeed_VehicleUsedBoost()
    {
        //Act
        _toyota.UseNitrousOxideEngine();

        //Assert
        _toyota.Speed.Should().Be(30);
    }
}