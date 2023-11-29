using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NuGet.Frameworks;
using SphereCalculator;

namespace SphereVolumeCalculateTest
{
    public class CalculateSphereTest
    {
        //we have to initialize from cacluatesphere 
        private CalculateSphere _calculateSphere;

        [SetUp]
        public void Setup()
        {
            //assign instance
            _calculateSphere = new CalculateSphere();
            
        }

        
        [Test]        
        public void GetVolumeOfSphere_Test()
        {
            //Assign
            var radiusA = 10;
            var radiusB = 12;

            //Act
            var sphereVolumeA = _calculateSphere.volumeOfSphere(radiusA);
            var sphereVolumeB = _calculateSphere.volumeOfSphere(radiusB);

            //Assert
            Assert.AreEqual(3141.59, sphereVolumeA);
            Assert.AreEqual(5428.67, sphereVolumeB);
        }

        [Test]
        public void Get0WhenInputIsNegative_Test()
        {
            var radius = -12;

            var sphereVolume = _calculateSphere.volumeOfSphere(radius);

            Assert.AreEqual(0, sphereVolume);
        }


        [Test]
        
        public void GetExceptionThrownWhenInputString_Test()
        {
          
           Assert.Throws<FormatException>(() => _calculateSphere.volumeOfSphere(double.Parse("dua")));                                
            
        }

        [TestCase(12)]
        [TestCase(13)]
        public void GetVolumeOfSphereNotEqual_Test(double radius)
        {
            //Assign
            //var radius = 12;

            //Act
            var sphereVolume = _calculateSphere.volumeOfSphere(radius);


            //Assert
            Assert.AreNotEqual(-5428.67, sphereVolume);
            
        }

        [Test]
        public void GetMaxMinOfSphereVolume_Test()
        {
            double minRadius = double.MinValue;
            double maxRadius = double.MaxValue;

            Assert.DoesNotThrow(() => _calculateSphere.volumeOfSphere(minRadius));
            Assert.DoesNotThrow(() => _calculateSphere.volumeOfSphere(maxRadius));
        }

        [Test]
        public void CalculateSphere_Test()
        {
            var radius = 12;

            var volumeSphere =_calculateSphere.volumeOfSphere(radius);

            Assert.IsTrue(volumeSphere > 0);
        }

    }
}