# 4-Column Shopping List

A Windows Forms application that helps you organize your shopping list into four convenient categories: Breakfast, Lunch, Dinner, and Extras.

## Features

- **Four Category Organization**: Separate your shopping items into Breakfast, Lunch, Dinner, and Extras columns for better meal planning
- **Easy Item Management**: 
  - Add items by typing and pressing Enter
  - Delete items with a single click
  - Real-time item count for each category
- **Text-to-Speech**: Listen to your shopping lists read aloud with built-in speech synthesis
  - Choose to hear individual categories or your entire list
  - Adjustable speech rate for faster playback
- **Save to File**: Export your shopping list to a formatted text file in your Documents folder
- **Simple Interface**: Clean, intuitive Windows Forms interface for quick list creation

## System Requirements

- Windows Operating System
- .NET Framework 4.8.1 or later
- Speech synthesis support (included in Windows)

## Installation

1. Download the latest release from the [Releases](https://github.com/HiTechCharles/4-Column-Shopping-List/releases) page
2. Extract the files to a folder of your choice
3. Run `4-Column Shopping List.exe`

## Usage

### Adding Items
1. Type an item name in any of the four category text boxes (Breakfast, Lunch, Dinner, or Extras)
2. Press Enter to add the item to that category's list
3. The item count updates automatically

### Removing Items
1. Click on an item in any list to select it
2. Click the corresponding "Delete" button to remove the selected item

### Listening to Your List
1. Select a category from the "Speak List" dropdown menu
2. Choose "Entire List" to hear all categories
3. Click the "Speak List" button to hear your items read aloud

### Saving Your List
1. Click the "Save List" button
2. Your list will be saved to: `Documents\4-Column Shopping List\Shopping List.txt`
3. The file includes the date and organized categories with item counts

## Building from Source

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.8.1 SDK

### Build Steps
1. Clone the repository:
   ```
   git clone https://github.com/HiTechCharles/4-Column-Shopping-List.git
   ```
2. Open `4-Column Shopping List.csproj` in Visual Studio
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)

## File Locations

- **Application Data**: `%OneDriveConsumer%\Documents\4-Column Shopping List\` or `%MyDocuments%\Documents\4-Column Shopping List\`
- **Saved Lists**: `Shopping List.txt` in the application data folder

## Version History

- **v4.4.0** - Current version
  - Four-category organization system
  - Text-to-speech functionality
  - Save to file feature
  - Item count tracking

## Author

**HiTechCharles**

## License

Copyright © 2026 HiTechCharles

## Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the [issues page](https://github.com/HiTechCharles/4-Column-Shopping-List/issues).

## Support

If you encounter any problems or have questions, please [open an issue](https://github.com/HiTechCharles/4-Column-Shopping-List/issues/new) on GitHub.
