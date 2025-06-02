## Links
REPO: https://github.com/StaplesArlo/ST10404431_PROG6221_POE.git
Youtube Video: 
## Overview
This project is a C# application designed to manage and interact with SA citizens in order to help them improve their security online.. It provides functionality to read questions and give answers that are stored in a file, list the questions, and retrieve specific answers based on user input.

## Features
- **Read QAs from a file**: Parses a file containing questions and answers.
- **List questions**: Displays all available questions to the user.
- **Retrieve answers**: Fetches the answer to a specific question by its number.
- **Error handling**: Gracefully handles file reading errors.

# File Structure
## 1. ReadQAs.cs
- Handles reading and managing QAs from a file.
- `files/QAs.txt` - Contains the questions and answers in a structured format.
## 2. Audios.cs
- Handles accessing and playing audio files in program.
- `files/Hello.wav`
- `files/FAQs.wav`
## 3. Program.cs 
Entry point of the application.

## Installation
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio 2022.
3. Ensure you have .NET 9 installed.
4. Build the solution to restore dependencies.

## Usage
1. Place your `QAs.txt` file in the specified directory:
2. Run the application.
3. Use the provided menu options to interact with the QAs:
   - List all questions.
   - Retrieve an answer by question number.
   - Ask questions through input

## Requirements
- **C# Version**: 12.0
- **.NET Target**: .NET 9

## Error Handling
If the file cannot be read, the application will display an error message with details about the issue.
---
   
