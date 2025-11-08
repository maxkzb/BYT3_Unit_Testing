using Tut2_s20123;

namespace Tut2_s20123_Tests
{
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5); 

        private readonly IShape cylinder = new Cylinder(3, 7); 
        
        private readonly IShape rectangle = new Rectangle(4, 8); 
        
        private readonly IShape cube = new Cube(4); 


        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateArea()
        {
            double expectedArea = 2 * Math.PI * 3 * (3 + 7);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(expectedArea).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            double expectedVolume = Math.PI * Math.Pow(3, 2) * 7;
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(expectedVolume).Within(0.001));
        }
        
        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32));
        }

        [Test]
        public void TestRectangleCalculateVolume_ShouldBeZero()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCubeCalculateArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(96));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64));
        }
    }
}