# Server Side

## STEP 1: Share a folder to your network.

How to share folder to a network: 
https://support.microsoft.com/en-us/windows/file-sharing-over-a-network-in-windows-b58704b2-f53a-4b82-7bc1-80f9994725bf#ID0EBD=Windows_11

## STEP 2: Save and extract the Save n load to your game directory

## STEP 3: Edit the 'setting.xml' file in the save and load directory

provide the shared folder network link

example: 
> _\\192.168.1.100_ is IP address of pc Server while _\saves_ is the name of the shared folder
````xml
<?xml version="1.0" encoding="utf-8" ?>
<Variable>
  <sharedFolder>\\192.168.1.100\Saves</sharedFolder> 
</Variable>
````
> \\{computer name}\saves   - this format is also applicable
````xml
<?xml version="1.0" encoding="utf-8" ?>
<Variable>
  <sharedFolder>\\Administrator\Saves</sharedFolder> 
</Variable>
````

## STEP 4: Adding games and save paths:

### Click Settings
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/6093a2f8-beec-4375-bbb3-d2e5874780c0)

### Password: admin
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/f0bf98a2-196c-4d59-b5e2-e823ad37ca8d)

### Click 'add'
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/c41f5ae0-3a34-4c02-a787-4ec0c3debefd)

### Fill up the Game and Save Path
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/5a5d63b6-8f5c-4861-9649-bb6c7130e5a4)

### click 'yes'
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/7e11164a-7b05-42b6-8e24-37886e5eac9d)

# Client side

## STEP 1: client's registration

### Click register and provide all of the necessary information
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/e8bc2d10-723f-4462-ac76-6d7c5297d5c4)

### Click ok to confirm button to register 
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/a32cdadb-0f25-46db-bb2b-7c24d67c56a9)

## STEP 2: Save and Load

### Log-in your account and click login
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/ed5501d7-7665-43fd-93cf-bbc3af6a789d)

### Select a game from the List box and click Save button if you want to save or click Load button to load a game
![image](https://github.com/raizar24/Save-N-Load/assets/76771070/85d998c2-610a-4fa4-ada8-248e7330b1c9)
