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
        }
        public void Subtest()
        {
            var calc = new Calc();
            var result = calc.Add(0, 0);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Add(1, 1);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Add(-1, 2);
            Assert.That(result, Is.EqualTo(-3));
            result = calc.Add(-1, -1);
            Assert.That(result, Is.EqualTo(0));
        }
        public void Multtest()
        {
            var calc = new Calc();
            var result = calc.Add(0, 0);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Add(1, 1);
            Assert.That(result, Is.EqualTo(1));
            result = calc.Add(-1, 2);
            Assert.That(result, Is.EqualTo(-2));
            result = calc.Add(-1, -1);
            Assert.That(result, Is.EqualTo(1));
        }
        public void Modtest()
        {
            var calc = new Calc();
            var result = calc.Add(0, 0);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Add(1, 1);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Add(100, 2);
            Assert.That(result, Is.EqualTo(0));
            result = calc.Add(101, 2);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
