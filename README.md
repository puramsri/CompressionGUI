Compression App (Windows Forms)

This project is a Windows Forms application that allows users to compress and decompress strings of repeating characters. The compression format is a simple form where the number of repeated characters is represented by a number followed by the character itself (e.g., 4a for aaaa). The decompression restores the original string.

Features
	•	Compress: Reduces repeating characters into a shorter format.
	•	Decompress: Restores compressed strings to their original format.

Prerequisites

Before you begin, make sure you have the following installed:
	•	.NET SDK 8+ – Download here.
	•	Visual Studio Code – Download here.
	•	C# Extension for VS Code – Install from Extensions (Ctrl+Shift+X in VS Code).

Getting Started

1. Clone the Repository

Clone this repository to your local machine.

git clone <your-repository-url>
cd CompressionGUI

2. Open the Project in Visual Studio Code

Launch Visual Studio Code and open the CompressionGUI project folder.

3. Restore Dependencies

Run the following command in the integrated terminal to restore the project dependencies:

dotnet restore

4. Build and Run the Application

To build and run the application, open the integrated terminal and execute:

dotnet build
dotnet run

This will launch the Windows Forms app. You will see a simple UI where you can input text and choose to either Compress or Decompress it.

How It Works

Compression

The compression method converts strings of repeating characters into a more compact form. For example:
	•	Input: aaaa
	•	Compressed: 4a

Decompression

The decompression method restores the compressed format back to the original string. For example:
	•	Input: 4a
	•	Decompressed: aaaa

Contributing

If you would like to contribute to this project, feel free to fork the repository and submit a pull request. Your contributions are always welcome!
