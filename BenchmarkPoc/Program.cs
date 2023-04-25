using BenchmarkDotNet.Running;
using BenchmarkPoc.BenchmarkClasses;
using System.Text;

//BenchmarkRunner.Run<DateParserBenchmark>();
//BenchmarkRunner.Run<ListIterationBenchmarck>();
//BenchmarkRunner.Run<OrderByIntBenchmark>();
//BenchmarkRunner.Run<OrderByStringBenchmark>();
//BenchmarkRunner.Run<StringCreationBenchmark>();
//BenchmarkRunner.Run<SwitchVsIfElseBenchmarck>();
//BenchmarkRunner.Run<LinqSearchFiltersBenchmark>();


//rodar em release
//pelo cli :
//dotnet build -c release
//dotnet caminho dll do projeto

string html = @"<div style=""display: flex; flex-direction: column; width: calc(100%/4 - 15px); margin: 7px; border-radius: 7px; padding: 20px; position: relative; justify-content: space-between; background: linear-gradient(138deg, rgba(134,167,154,1) 0%, rgba(0,139,60,1) 100%);"">
   <div style=""width: 100%; padding-bottom: 10px;  display: inline-flex; justify-content: flex-start; align-items: center;"">
      <h2 style=""font-size: 1.1rem; color: #fff;  width: 100%;font-weight: 600;"">Guia curitiba</h2>
   </div>
   <div>
      <div style=""    display: inline-flex;
         justify-content: flex-start;
         align-items: center;"">
         <h2 style=""    font-size: 1rem; font-weight: 600;
            color: #fff;"">Meus ingressos</h2>
      </div>
      <div style=""width: 100%; height: auto; border-radius: 7px; background: rgba(255,255,255,.2); padding: 10px; margin-top: 5px;"">
         <div style=""width: 100%; height: auto; display: inline-flex; justify-content: space-between; border-bottom: 1px solid #ffffff59;"">
            <p style=""color: #fff; font-size: .8rem;""> Inscritos
            </p>
            <p style=""color: #fff; font-size: .8rem;""> {0}
            </p>
         </div>
         <div style=""width: 100%; max-height: 60px;  overflow-y: auto;   margin-top: 10px"">
            <ul style=""list-style-type: none; margin-top: 5px"">
            <!-- 
			  <li style=""color: #fff; font-size: .8rem;"">	{0} </li>
			-->
			{1}
            </ul>
         </div>
      </div>

      <div style=""margin-top: 5px;     width: 100%;
         display: flex;
         justify-content: center;
         align-items: center;
         margin-top: 10px;
         z-index: 1;"">
         <a href=""#"" style=""display: inline-flex;
            padding: 7px 20px;
            border: 1px solid #fff;
            border-radius: 7px;
            color: #fff;
            justify-content: center;
            align-items: center;
            text-decoration: none;
            outline: none;"">
         Saiba mais
         </a>
      </div>
   </div>
</div>";

var pFrom = html.IndexOf("<!--");
var pFromSemOsCaracteresIndex = pFrom + 4;

var pTo = html.IndexOf("-->");
var pToComCaracteresIndex = pTo + 3;

var loop = html.Substring(pFromSemOsCaracteresIndex, pTo - pFromSemOsCaracteresIndex);

var htmlSemComentario = html.Remove(pFrom, pToComCaracteresIndex - pFrom);

var arr = new int[] { 1, 2,3 };

var stringBuilder = new StringBuilder();

foreach (var item in arr)
{
    var itemLoop = string.Format(loop, item);
    stringBuilder.Append(itemLoop);
}

var result = string.Format(htmlSemComentario, 3, stringBuilder);

Console.WriteLine(result);




