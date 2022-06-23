// namespace TasksInParallel
// {
//     internal class testAsync
//     {
//         public static async Task Main()
//         {
//             var task1 = Task.Run(() =>
//             {
//                 Thread.Sleep(2000);
//                 // Console.WriteLine("Finished Task 1");
//                 return "Finished Task 1";
//             });

//             var task2 = Task.Run(() =>
//             {
//                 Thread.Sleep(2000);
//                 return "Finished Task 2";
//             });


//             var task3 = Task.Run(() =>
//             {
//                 Thread.Sleep(2000);
//                 return "Finished Task 3";
//             });



//             // var task2 = Task.Run(() => CpuWork2(10));

//             var result1 = await task1;
//             var result2 = await task2;
//             var result3 = await task3;

//             var results = await Task.WhenAll(task1, task2, task3);
//             Console.WriteLine(results);

//         }

//     }

// }