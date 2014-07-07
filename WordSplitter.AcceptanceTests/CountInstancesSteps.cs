using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace WordSplitter.AcceptanceTests
{
    [Binding]
    public class CountInstancesSteps
    {
        private string _sentence;
        private InstanceCounter _counter;
        
        [Given(@"I have a sentence ""(.*)""")]
        public void GivenIHaveASentence(string sentence)
        {
            _sentence = sentence;
        }
        
        [When(@"I call CountInstances")]
        public void WhenICallCountInstances()
        {
            _counter = new InstanceCounter();
        }
        
        [Then(@"the result should be")]
        public void ThenTheResultShouldBe(Table table)
        {
            var expected = table.Rows.ToDictionary(row => row["Word"], row => int.Parse(row["Count"]));

            CollectionAssert.AreEqual(expected, _counter.Count(_sentence));
        }
    }
}
