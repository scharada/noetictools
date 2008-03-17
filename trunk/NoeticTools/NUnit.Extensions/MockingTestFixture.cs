using NMock2;
using NUnit.Framework;


namespace NUnit.Extensions
{
	public abstract class MockingTestFixture
	{
		private Mockery mockery;

		[SetUp]
		public void BaseSetUp()
		{
			mockery = new Mockery();
			SetUp();
		}

		protected abstract void SetUp();

		[TearDown]
		public void BaseTearDown()
		{
			mockery.VerifyAllExpectationsHaveBeenMet();
			TearDown();
		}

		protected virtual void TearDown()
		{
		}

		public T NewMock<T>()
		{
			return mockery.NewMock<T>();
		}
	}
}