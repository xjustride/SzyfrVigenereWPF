# Vigenère Cipher Application

## Overview

This repository houses a WPF (Windows Presentation Foundation) application built with .NET 6.0, demonstrating the implementation of the Vigenère cipher. The Vigenère cipher is a method of encrypting alphabetic text by using a simple form of polyalphabetic substitution. This application provides an easy-to-use interface for encrypting and decrypting text using this classical cipher, with a focus on demonstrating its functionality within a modern .NET application.

## Features

- **Text Encryption**: Allows the encryption of text using a keyword-based Vigenère cipher.
- **Text Decryption**: Enables the decryption of text that was encrypted with the Vigenère cipher, provided the correct keyword is known.
- **User-friendly Interface**: Offers a straightforward GUI for easy interaction with the cipher functionalities.
- **.NET 6.0 and WPF**: Built using the latest .NET technology, ensuring smooth operation and compatibility with current Windows environments.

## Requirements

- Windows OS capable of running WPF applications.
- .NET 6.0 SDK or a compatible runtime environment installed on your machine.

## Installation

1. **Clone the Repository**: Begin by cloning this repository to your local machine using Git.

    ```
    git clone https://github.com/xjustride/SzyfrVigenereWPF.git
    ```

2. **Open the Project**: Navigate to the cloned directory and open the `.sln` file in Visual Studio or your preferred IDE that supports .NET 6.0 development.

3. **Build the Application**: Compile the application using the build functionality of your IDE or via the .NET CLI with the command:

    ```
    dotnet build
    ```

4. **Run the Application**: Launch the application from your IDE, or use the .NET CLI to run the application with:

    ```
    dotnet run
    ```

## Usage

To use the Vigenère cipher application:

1. **Enter Text**: Input the text you wish to encrypt or decrypt in the provided text box.
2. **Specify Keyword**: Enter the keyword that will be used for the encryption or decryption process.
3. **Encrypt/Decrypt**: Click the "Encrypt" button to encrypt your input text or the "Decrypt" button to decrypt it.
4. **View Result**: The output text box will display the result of the encryption or decryption process.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments

- This application was developed to demonstrate the practical application of the Vigenère cipher in a modern software development environment.
- Special thanks to all contributors for their support and contributions to this project.
