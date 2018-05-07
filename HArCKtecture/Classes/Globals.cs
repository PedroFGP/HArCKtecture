
namespace HArCKtecture.Classes
{
    public static class Globals
    {
        public const string DIRECTORY_NAME = "Desafios";
        public const string AVAILABLE_CHALLENGES = "Desafios Disponíveis - {0}/{1}";

        public const string BASE_HELP_HTML = @"
        <html>
        <style>
        table {
            border-collapse: collapse;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
        </style>
        <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>
        <body style='font: 12pt Segoe UI;'>
            <h1 style='font: 16pt Segoe UI; text-align: center;'>{Title}</h1>
            <table style='border: 2px solid black; margin: 0px auto;' align='center'>
            <tr style='vertical-align: middle; text-align: center;'>
                <td style='padding: 5px; vertical-align: top;'>
                    <img src='info'/>
                </td>
                <td style='padding: 5px;'>
                    {Description}
                </td>
            </tr>
            </table>
        </body>
        </html>";

        public static bool ResetChallenges = false;
    }
}
