 GetProcessedDataAsync("some text");
Console.WriteLine("Some other Indepensent Work");

Console.WriteLine("The End...!");
Console.ReadKey();

async void GetProcessedDataAsync(string data)
{
    Console.WriteLine("GetProcessedDataAsync Starts");
    string processedData = await ProcessDataAsync(data);
    Console.WriteLine(processedData);
}

 async Task<string> ProcessDataAsync(string data)
{
    // Simulate data processing
    await Task.Delay(5000);
    Console.WriteLine("ProcessDataAsync End");
    return data.ToUpper();
}


