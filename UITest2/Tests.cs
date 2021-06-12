//using System;
//using System.IO;
//using System.Linq;
//using AutoFixture;
//using NUnit.Framework;
//using Xamarin.UITest;
//using Xamarin.UITest.Queries;
using Autofac.Extras.Moq;
using NUnit.Framework;
using FluentAssertions;
using Xamarin.Forms;
using AutoFixture;
using System.Threading.Tasks;
using System.Linq;
using Moq;
using App3.Deneme;

namespace UITest2
{
    [TestFixture]
    public class Tests
    {
        //IApp app;
        //Platform platform;

        private Fixture _fixture;

        public Tests() => _fixture = new Fixture();

        [Test]
        public void CreatingHomePageViewModel_WhenSuccessfull_VideosIsEmpty()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var viewModel = mock.Create<BookListViewModel>();

                viewModel.GetAll().Any();
            }
        }

        
    }
}
