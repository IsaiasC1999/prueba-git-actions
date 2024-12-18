Console.WriteLine("Iniciando temporizador...");
        Console.WriteLine("Presiona 'Enter' para detenerlo.\n");

        int contador = 0;

        // Ejecutar el temporizador en un bucle
        while (!Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            Console.WriteLine($"Segundos transcurridos: {contador}");
            contador++;
            await Task.Delay(1000); // Esperar 1 segundo
        }

        Console.WriteLine("\nTemporizador detenido.");