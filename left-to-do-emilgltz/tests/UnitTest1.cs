using Xunit;

namespace left_to_do_emilgltz;

public class UnitTest1
{
    [Fact]
    public void TaskToListTest()
    {
        //arrange
        var testManager = new TaskManager();




        var testSimple = new SimpleTask("test");
        testManager.SimpleTasksList.Add((testSimple));





        var testDeadline = new DeadlineTask("test", 2);
        testManager.DeadlineTasksList.Add(testDeadline);


        var expected = 2;

        //act
        var resultDeadline = testManager.DeadlineTasksList.Count;
        var resultSimple = testManager.SimpleTasksList.Count;

        var totalResult = resultDeadline + resultSimple;

        //assert
        Assert.Equal(expected, totalResult);


    }

    

    [Fact]
    
    public void ArchiveTasksTest()
    {

        //arrange
        var testManager = new TaskManager();


        var testSimple = new SimpleTask("test");
        testSimple.Completed = true;


        var testSimple1 = new SimpleTask("test1");
        testSimple1.Completed = false;
        
        
        
        
        var testlist = testManager.SimpleTasksList;
        testlist.Add(testSimple);
        testlist.Add(testSimple1);

        //act

        testManager.MoveCompletedTasks(testlist);

       
        var expectedArchivedList = testManager.ArchivedTasksList.Count;


        
        var actualArchivedlist = 1;

        //assert


        
        Assert.Equal(expectedArchivedList,actualArchivedlist);









    }
}