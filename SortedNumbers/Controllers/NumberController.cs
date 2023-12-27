using Microsoft.AspNetCore.Mvc;
using SortedNumbers.Utils;
namespace SortedNumbers.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NumberController : Controller
    {
        private readonly IOFiles files = new IOFiles();

        private readonly Sorting sorting = new Sorting();       

        // Get numbers by sort
        // GET: api/NumberController/GetSortedNumbers
        [HttpGet]
        public IActionResult GetSortedNumbers(string num)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var numbers = sorting.SimpleSort(num);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            files.SaveToFile(numbers);
            return numbers == null ? NotFound() : Ok(numbers);
        }

        // Get numbers by bubble sort
        // GET: api/NumberController/GetSortedNumbersByBubbleSort
        [HttpGet]
        public IActionResult GetSortedNumbersByBubbleSort(string num)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var numbers = sorting.BubbleSort(num);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            files.SaveToFile(numbers);
            return numbers == null ? NotFound() : Ok(numbers);
        }



        // Get last saved numbers
        // GET: api/NumberController/GetLastSortedNumbers
        [HttpGet]
        public IActionResult GetLastSortedNumbers()
        {
            var numbers = files.ReadFromFile();
            return numbers == null ? NotFound() : Ok(numbers); ;
        }


    }
}
