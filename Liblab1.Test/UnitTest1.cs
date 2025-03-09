namespace Liblab1.Test
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Addtest()
        {
            var calc = new Calc();
            var result = calc.Add(0, 0);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Add(1, 1);
            Assert.That(result, Is.EqualTo(2));
            result = calc.Add(-1, 2);
            Assert.That(result, Is.EqualTo(1));
            result = calc.Add(-1, -1);
            Assert.That(result, Is.EqualTo(-2));
            result = calc.Add(2^31, 2^31);
            Assert.That(result, Is.EqualTo(2^32));
        }
        [Test]
        public void Subtest()
        {
            var calc = new Calc();
            var result = calc.Sub(0, 0);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Sub(1, 1);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Sub(-1, 2);
            Assert.That(result, Is.EqualTo(-3));
            result = calc.Sub(-1, -1);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Multtest()
        {
            var calc = new Calc();
            var result = calc.Mult(0, 0);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Mult(1, 1);
            Assert.That(result, Is.EqualTo(1));
            result = calc.Mult(-1, 2);
            Assert.That(result, Is.EqualTo(-2));
            result = calc.Mult(-1, -1);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Modtest()
        {
            var calc = new Calc();
            var result = calc.Mod(0, 0);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Mod(1, 1);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Mod(100, 2);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Mod(101, 2);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
