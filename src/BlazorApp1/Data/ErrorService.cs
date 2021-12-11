using BlazorApp1.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ErrorService
    {
        private readonly IWebHostEnvironment _env;

        public ErrorService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<ErrorCodeModel[]> GetListAsync()
        {
            var path = Path.Combine(_env.WebRootPath, "data", "errors.json");
            var content = await File.ReadAllTextAsync(path);
            var data = JsonConvert.DeserializeObject<ErrorCodeResults>(content);

            return data.Errors;
        }
    }
}
