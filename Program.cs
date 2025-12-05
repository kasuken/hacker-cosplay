using Spectre.Console;

class Program
{
    static readonly Random Random = new();

    static readonly string[] HackerPhrases =
    [
        "Initializing kernel bypass...",
        "Connecting to mainframe...",
        "Bypassing firewall protocols...",
        "Injecting payload into memory...",
        "Decrypting secure channels...",
        "Establishing backdoor connection...",
        "Loading exploit modules...",
        "Scanning network vulnerabilities...",
        "Compiling rootkit drivers...",
        "Overriding security protocols...",
        "Extracting encrypted data packets...",
        "Tunneling through proxy servers...",
        "Spoofing MAC addresses...",
        "Brute forcing authentication...",
        "Deploying polymorphic malware...",
        "Hijacking session tokens...",
        "Cracking RSA encryption keys...",
        "Intercepting network traffic...",
        "Modifying system registers...",
        "Escalating user privileges...",
        "Patching kernel modules...",
        "Disabling intrusion detection...",
        "Masking digital footprint...",
        "Encoding steganographic payloads...",
        "Fragmenting packet headers...",
        "Cloning authentication certificates...",
        "Reversing binary obfuscation...",
        "Mapping network topology...",
        "Exploiting buffer overflow...",
        "Pivoting through compromised nodes..."
    ];

    static readonly string[] TechTerms =
    [
        "0x7F3A9B2C", "kernel32.dll", "sys_execve", "TCP/443",
        "SHA-256", "AES-256-GCM", "RSA-4096", "ECDSA",
        "/dev/null", "/etc/shadow", "root@localhost",
        "192.168.1.", "10.0.0.", "172.16.0.",
        "PORT STATE SERVICE", "VULNERABILITY DETECTED",
        "ACCESS GRANTED", "BUFFER OVERFLOW", "STACK SMASH",
        "HEAP CORRUPTION", "PRIVILEGE ESCALATION",
        "REMOTE CODE EXECUTION", "SQL INJECTION",
        "CROSS-SITE SCRIPTING", "ZERO-DAY EXPLOIT"
    ];

    static readonly string HexChars = "0123456789ABCDEF";

    static async Task Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.Clear();

        var cts = new CancellationTokenSource();

        Console.CancelKeyPress += (_, e) =>
        {
            e.Cancel = true;
            cts.Cancel();
        };

        AnsiConsole.MarkupLine("[bold green]HACKER COSPLAY v1.0[/]");
        AnsiConsole.MarkupLine("[dim]Press Ctrl+C to exit[/]\n");

        try
        {
            await RunHackerAnimation(cts.Token);
        }
        catch (OperationCanceledException)
        {
            // Expected when user cancels
        }
        finally
        {
            Console.CursorVisible = true;
            AnsiConsole.MarkupLine("\n[bold red]Connection terminated.[/]");
        }
    }

    static async Task RunHackerAnimation(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            int action = Random.Next(5);

            switch (action)
            {
                case 0:
                    await DisplayHackerPhrase(cancellationToken);
                    break;
                case 1:
                    await DisplayHexDump(cancellationToken);
                    break;
                case 2:
                    await DisplayProgressBar(cancellationToken);
                    break;
                case 3:
                    await DisplayMatrixRain(cancellationToken);
                    break;
                case 4:
                    await DisplayNetworkScan(cancellationToken);
                    break;
            }

            await Task.Delay(Random.Next(100, 500), cancellationToken);
        }
    }

    static async Task DisplayHackerPhrase(CancellationToken cancellationToken)
    {
        string phrase = HackerPhrases[Random.Next(HackerPhrases.Length)];
        string color = GetRandomColor();

        foreach (char c in phrase)
        {
            if (cancellationToken.IsCancellationRequested) return;
            AnsiConsole.Markup($"[{color}]{c}[/]");
            await Task.Delay(Random.Next(10, 50), cancellationToken);
        }

        AnsiConsole.MarkupLine($" [{GetRandomColor()}][[OK]][/]");
    }

    static async Task DisplayHexDump(CancellationToken cancellationToken)
    {
        int lines = Random.Next(2, 6);
        AnsiConsole.MarkupLine("[dim]Memory dump:[/]");

        for (int i = 0; i < lines; i++)
        {
            if (cancellationToken.IsCancellationRequested) return;

            string address = $"0x{Random.Next(0x1000, 0xFFFF):X4}";
            string hex = GenerateRandomHex(16);

            AnsiConsole.MarkupLine($"[cyan]{address}[/]: [green]{hex}[/]");
            await Task.Delay(Random.Next(50, 150), cancellationToken);
        }
    }

    static async Task DisplayProgressBar(CancellationToken cancellationToken)
    {
        string term = TechTerms[Random.Next(TechTerms.Length)];

        int width = Random.Next(15, 30);
        for (int i = 0; i <= width; i++)
        {
            if (cancellationToken.IsCancellationRequested) return;

            int percent = (int)((double)i / width * 100);
            string bar = new string('█', i) + new string('░', width - i);
            AnsiConsole.Markup($"\r[yellow]Processing {term}[/] [[{bar}]] {percent}%");
            await Task.Delay(Random.Next(20, 80), cancellationToken);
        }

        AnsiConsole.MarkupLine($" [bold green]COMPLETE[/]");
    }

    static async Task DisplayMatrixRain(CancellationToken cancellationToken)
    {
        int columns = Math.Min(Console.WindowWidth - 1, 60);
        int rows = Random.Next(3, 8);

        for (int r = 0; r < rows; r++)
        {
            if (cancellationToken.IsCancellationRequested) return;

            for (int c = 0; c < columns; c++)
            {
                char ch = (char)Random.Next(33, 127);
                string color = Random.Next(3) == 0 ? "bold green" : "green";
                string escaped = ch == '[' ? "[[" : ch == ']' ? "]]" : ch.ToString();
                AnsiConsole.Markup($"[{color}]{escaped}[/]");
            }

            AnsiConsole.WriteLine();
            await Task.Delay(Random.Next(30, 100), cancellationToken);
        }
    }

    static async Task DisplayNetworkScan(CancellationToken cancellationToken)
    {
        string baseIp = TechTerms[Random.Next(10, 13)];
        AnsiConsole.MarkupLine($"[bold cyan]Scanning {baseIp}0/24...[/]");

        int hosts = Random.Next(3, 8);
        for (int i = 0; i < hosts; i++)
        {
            if (cancellationToken.IsCancellationRequested) return;

            int lastOctet = Random.Next(1, 255);
            int port = Random.Next(1, 65535);
            string status = Random.Next(2) == 0 ? "[green]OPEN[/]" : "[red]FILTERED[/]";

            AnsiConsole.MarkupLine($"  [dim]{baseIp}{lastOctet}:{port}[/] {status}");
            await Task.Delay(Random.Next(100, 300), cancellationToken);
        }
    }

    static string GenerateRandomHex(int bytes)
    {
        char[] hex = new char[bytes * 3 - 1];
        for (int i = 0; i < bytes; i++)
        {
            hex[i * 3] = HexChars[Random.Next(16)];
            hex[i * 3 + 1] = HexChars[Random.Next(16)];
            if (i < bytes - 1) hex[i * 3 + 2] = ' ';
        }
        return new string(hex);
    }

    static string GetRandomColor()
    {
        string[] colors = ["green", "cyan", "yellow", "red", "magenta", "blue"];
        return colors[Random.Next(colors.Length)];
    }
}