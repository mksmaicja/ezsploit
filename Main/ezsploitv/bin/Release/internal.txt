local GUIezsploit = Instance.new("ScreenGui")
local MainBorder = Instance.new("Frame")
local TopFrame = Instance.new("Frame")
local TextLabel = Instance.new("TextLabel")
local leftframe = Instance.new("Frame")
local TextLabel_2 = Instance.new("TextLabel")
local Codebutton = Instance.new("ImageButton")
local SettButton = Instance.new("ImageButton")
local Frame = Instance.new("Frame")
local TextBox = Instance.new("TextBox")
local Execute = Instance.new("TextButton")
local script1 = Instance.new("TextButton")
local script2 = Instance.new("TextButton")
local script3 = Instance.new("TextButton")
local script4 = Instance.new("TextButton")
local script7 = Instance.new("TextButton")
local script6 = Instance.new("TextButton")
local script5 = Instance.new("TextButton")
local Clear = Instance.new("TextButton")
local ImageLabel = Instance.new("ImageLabel")
local FrameSet = Instance.new("Frame")
local TextLabel_3 = Instance.new("TextLabel")
local TextButton = Instance.new("TextButton")
local TextButton_2 = Instance.new("TextButton")
local DisplayName = Instance.new("TextBox")
local UserName = Instance.new("TextBox")
local HWID = Instance.new("TextBox")
local WATERMARK = Instance.new("Frame")
local WATERlabel = Instance.new("TextLabel")

--Properties:

GUIezsploit.Name = "GUIezsploit"
GUIezsploit.Parent = game.Players.LocalPlayer:WaitForChild("PlayerGui")

MainBorder.Name = "MainBorder"
MainBorder.Parent = GUIezsploit
MainBorder.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
MainBorder.Position = UDim2.new(0.0299543887, 0, 0.0511221886, 0)
MainBorder.Size = UDim2.new(0, 737, 0, 395)

TopFrame.Name = "TopFrame"
TopFrame.Parent = MainBorder
TopFrame.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
TopFrame.BorderColor3 = Color3.fromRGB(27, 42, 53)
TopFrame.BorderSizePixel = 0
TopFrame.Size = UDim2.new(0, 737, 0, 38)

TextLabel.Parent = TopFrame
TextLabel.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
TextLabel.BorderSizePixel = 0
TextLabel.Size = UDim2.new(0, 242, 0, 38)
TextLabel.Font = Enum.Font.SourceSans
TextLabel.Text = "EzSploit Internal"
TextLabel.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel.TextSize = 24.000

leftframe.Name = "leftframe"
leftframe.Parent = MainBorder
leftframe.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
leftframe.BorderColor3 = Color3.fromRGB(27, 42, 53)
leftframe.BorderSizePixel = 0
leftframe.Size = UDim2.new(0, 49, 0, 395)

TextLabel_2.Parent = leftframe
TextLabel_2.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
TextLabel_2.BorderSizePixel = 0
TextLabel_2.Position = UDim2.new(0.122448981, 0, 0.903797507, 0)
TextLabel_2.Size = UDim2.new(0, 43, 0, 38)
TextLabel_2.Font = Enum.Font.SourceSans
TextLabel_2.Text = "V2.2"
TextLabel_2.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_2.TextSize = 24.000

Codebutton.Name = "Code button"
Codebutton.Parent = leftframe
Codebutton.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Codebutton.BorderSizePixel = 0
Codebutton.Position = UDim2.new(0.0204081628, 0, 0.200000003, 0)
Codebutton.Size = UDim2.new(0, 48, 0, 48)
Codebutton.Image = "rbxassetid://13737518565"

SettButton.Name = "Sett Button"
SettButton.Parent = leftframe
SettButton.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
SettButton.BorderSizePixel = 0
SettButton.Position = UDim2.new(0.0204081628, 0, 0.336708844, 0)
SettButton.Size = UDim2.new(0, 48, 0, 48)
SettButton.Image = "rbxassetid://13737525150"

Frame.Parent = MainBorder
Frame.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Frame.Position = UDim2.new(0.0705563128, 0, 0.0987341776, 0)
Frame.Size = UDim2.new(0, 685, 0, 356)
Frame.Visible = false

TextBox.Parent = Frame
TextBox.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
TextBox.Position = UDim2.new(0.01605835, 0, 0.0842696652, 0)
TextBox.Size = UDim2.new(0, 662, 0, 260)
TextBox.ClearTextOnFocus = false
TextBox.Font = Enum.Font.SourceSans
TextBox.MultiLine = true
TextBox.Text = "Welcome to EzSploit Internal. Select tab to initialize save system first time."
TextBox.TextColor3 = Color3.fromRGB(255, 255, 255)
TextBox.TextSize = 14.000
TextBox.TextWrapped = true
TextBox.TextXAlignment = Enum.TextXAlignment.Left
TextBox.TextYAlignment = Enum.TextYAlignment.Top

Execute.Name = "Execute"
Execute.Parent = Frame
Execute.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
Execute.Position = UDim2.new(0.0160583947, 0, 0.842696607, 0)
Execute.Size = UDim2.new(0, 163, 0, 41)
Execute.Font = Enum.Font.SourceSans
Execute.Text = "Execute"
Execute.TextColor3 = Color3.fromRGB(255, 255, 255)
Execute.TextSize = 14.000

script1.Name = "script1"
script1.Parent = Frame
script1.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
script1.Position = UDim2.new(0.0160583947, 0, 0.00842696615, 0)
script1.Size = UDim2.new(0, 95, 0, 27)
script1.Font = Enum.Font.SourceSans
script1.Text = "Script1"
script1.TextColor3 = Color3.fromRGB(255, 255, 255)
script1.TextSize = 14.000

script2.Name = "script2"
script2.Parent = Frame
script2.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
script2.Position = UDim2.new(0.154744536, 0, 0.00842696615, 0)
script2.Size = UDim2.new(0, 95, 0, 27)
script2.Font = Enum.Font.SourceSans
script2.Text = "Script2"
script2.TextColor3 = Color3.fromRGB(255, 255, 255)
script2.TextSize = 14.000

script3.Name = "script3"
script3.Parent = Frame
script3.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
script3.Position = UDim2.new(0.293430656, 0, 0.00842696615, 0)
script3.Size = UDim2.new(0, 95, 0, 27)
script3.Font = Enum.Font.SourceSans
script3.Text = "Script3"
script3.TextColor3 = Color3.fromRGB(255, 255, 255)
script3.TextSize = 14.000

script4.Name = "script4"
script4.Parent = Frame
script4.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
script4.Position = UDim2.new(0.43065691, 0, 0.00842696801, 0)
script4.Size = UDim2.new(0, 95, 0, 27)
script4.Font = Enum.Font.SourceSans
script4.Text = "Script4"
script4.TextColor3 = Color3.fromRGB(255, 255, 255)
script4.TextSize = 14.000

script7.Name = "script7"
script7.Parent = Frame
script7.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
script7.Position = UDim2.new(0.843795598, 0, 0.00842696801, 0)
script7.Size = UDim2.new(0, 95, 0, 27)
script7.Font = Enum.Font.SourceSans
script7.Text = "Script7"
script7.TextColor3 = Color3.fromRGB(255, 255, 255)
script7.TextSize = 14.000

script6.Name = "script6"
script6.Parent = Frame
script6.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
script6.Position = UDim2.new(0.706569314, 0, 0.00842696615, 0)
script6.Size = UDim2.new(0, 95, 0, 27)
script6.Font = Enum.Font.SourceSans
script6.Text = "Script6"
script6.TextColor3 = Color3.fromRGB(255, 255, 255)
script6.TextSize = 14.000

script5.Name = "script5"
script5.Parent = Frame
script5.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
script5.Position = UDim2.new(0.567883253, 0, 0.00842696615, 0)
script5.Size = UDim2.new(0, 95, 0, 27)
script5.Font = Enum.Font.SourceSans
script5.Text = "Script5"
script5.TextColor3 = Color3.fromRGB(255, 255, 255)
script5.TextSize = 14.000

Clear.Name = "Clear"
Clear.Parent = Frame
Clear.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
Clear.Position = UDim2.new(0.743065655, 0, 0.842696607, 0)
Clear.Size = UDim2.new(0, 163, 0, 41)
Clear.Font = Enum.Font.SourceSans
Clear.Text = "Clear"
Clear.TextColor3 = Color3.fromRGB(255, 255, 255)
Clear.TextSize = 14.000

ImageLabel.Parent = MainBorder
ImageLabel.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
ImageLabel.BorderSizePixel = 0
ImageLabel.Size = UDim2.new(0, 50, 0, 50)
ImageLabel.Image = "rbxassetid://13733883347"

FrameSet.Name = "FrameSet"
FrameSet.Parent = MainBorder
FrameSet.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
FrameSet.Position = UDim2.new(0.0709999949, 0, 0.0989999473, 0)
FrameSet.Size = UDim2.new(0, 684, 0, 356)

TextLabel_3.Parent = FrameSet
TextLabel_3.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
TextLabel_3.BorderSizePixel = 0
TextLabel_3.Size = UDim2.new(0, 84, 0, 29)
TextLabel_3.Font = Enum.Font.SourceSans
TextLabel_3.Text = "UserInfo:"
TextLabel_3.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_3.TextSize = 14.000

TextButton.Parent = FrameSet
TextButton.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
TextButton.Position = UDim2.new(0.106725149, 0, 0, 0)
TextButton.Size = UDim2.new(0, 115, 0, 29)
TextButton.Font = Enum.Font.SourceSans
TextButton.Text = "Print in console (F9)"
TextButton.TextColor3 = Color3.fromRGB(255, 255, 255)
TextButton.TextSize = 14.000

TextButton_2.Parent = FrameSet
TextButton_2.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
TextButton_2.Position = UDim2.new(0, 0, 0.915730357, 0)
TextButton_2.Size = UDim2.new(0, 83, 0, 29)
TextButton_2.Font = Enum.Font.SourceSans
TextButton_2.Text = "Watermark"
TextButton_2.TextColor3 = Color3.fromRGB(255, 255, 255)
TextButton_2.TextSize = 14.000

DisplayName.Name = "DisplayName"
DisplayName.Parent = FrameSet
DisplayName.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
DisplayName.BorderSizePixel = 0
DisplayName.Position = UDim2.new(-4.47034836e-08, 0, 0.10674157, 0)
DisplayName.Size = UDim2.new(0, 681, 0, 17)
DisplayName.ClearTextOnFocus = false
DisplayName.Font = Enum.Font.SourceSans
DisplayName.Text = "kys"
DisplayName.TextColor3 = Color3.fromRGB(255, 255, 255)
DisplayName.TextSize = 14.000
DisplayName.TextXAlignment = Enum.TextXAlignment.Left

UserName.Name = "UserName"
UserName.Parent = FrameSet
UserName.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
UserName.BorderSizePixel = 0
UserName.Position = UDim2.new(-4.45870683e-08, 0, 0.154494375, 0)
UserName.Size = UDim2.new(0, 681, 0, 17)
UserName.ClearTextOnFocus = false
UserName.Font = Enum.Font.SourceSans
UserName.Text = "kys"
UserName.TextColor3 = Color3.fromRGB(255, 255, 255)
UserName.TextSize = 14.000
UserName.TextXAlignment = Enum.TextXAlignment.Left

HWID.Name = "HWID"
HWID.Parent = FrameSet
HWID.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
HWID.BorderSizePixel = 0
HWID.Position = UDim2.new(-4.45870683e-08, 0, 0.196629211, 0)
HWID.Size = UDim2.new(0, 681, 0, 17)
HWID.ClearTextOnFocus = false
HWID.Font = Enum.Font.SourceSans
HWID.Text = "kys"
HWID.TextColor3 = Color3.fromRGB(255, 255, 255)
HWID.TextSize = 14.000
HWID.TextXAlignment = Enum.TextXAlignment.Left

WATERMARK.Name = "WATERMARK"
WATERMARK.Parent = GUIezsploit
WATERMARK.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
WATERMARK.BorderSizePixel = 0
WATERMARK.Position = UDim2.new(0, 0, 0.960099757, 0)
WATERMARK.Size = UDim2.new(0, 134, 0, 32)

WATERlabel.Name = "WATERlabel"
WATERlabel.Parent = WATERMARK
WATERlabel.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
WATERlabel.BorderSizePixel = 0
WATERlabel.Position = UDim2.new(-0.0149253728, 0, 0.03125, 0)
WATERlabel.Size = UDim2.new(0, 136, 0, 31)
WATERlabel.Font = Enum.Font.SourceSans
WATERlabel.Text = "powered by EzSploit"
WATERlabel.TextColor3 = Color3.fromRGB(255, 255, 255)
WATERlabel.TextSize = 14.000
WATERlabel.TextStrokeColor3 = Color3.fromRGB(255, 255, 255)

-- Scripts:

local function RCDHFMX_fake_script() -- MainBorder.Drag 
	local script = Instance.new('LocalScript', MainBorder)

	script.Parent.Active = true
	script.Parent.Draggable = true
	
	
end
coroutine.wrap(RCDHFMX_fake_script)()
local function ZYMD_fake_script() -- MainBorder.OpenClose 
	local script = Instance.new('LocalScript', MainBorder)

	local Open = true
	script.Parent.Visible = false
	
	local UserInputService = game:GetService("UserInputService")
	
	UserInputService.InputBegan:Connect(function(KeyCode)
		if KeyCode.KeyCode == Enum.KeyCode.Insert then 
			if Open == true then
				script.Parent.Visible = true
				
				Open = false
			else
				script.Parent.Visible = false
				Open = true
			end
		end
	end)
end
coroutine.wrap(ZYMD_fake_script)()
local function YBBXKI_fake_script() -- Codebutton.LocalScript 
	local script = Instance.new('LocalScript', Codebutton)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		script.Parent.Parent.Parent.Frame.Visible = true
		script.Parent.Parent.Parent.FrameSet.Visible = false
	end)
end
coroutine.wrap(YBBXKI_fake_script)()
local function KEMBBCZ_fake_script() -- SettButton.LocalScript 
	local script = Instance.new('LocalScript', SettButton)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		script.Parent.Parent.Parent.Frame.Visible = false
		script.Parent.Parent.Parent.FrameSet.Visible = true
	end)
end
coroutine.wrap(KEMBBCZ_fake_script)()
local function HFZOCZ_fake_script() -- TextBox.LocalScript 
	local script = Instance.new('LocalScript', TextBox)

	script.Parent.Parent.Parent.Frame.Visible = true
	script.Parent.Parent.Parent.FrameSet.Visible = false
	
	local folderex = false
	folderex = isfolder("ezsploit")
	
	local scriptex = false
	scriptex = isfile("ezsploit\\script.txt")
	
	local scriptex1 = false
	scriptex1 = isfile("ezsploit\\script1.txt")
	
	local scriptex2 = false
	scriptex2 = isfile("ezsploit\\script2.txt")
	
	local scriptex3 = false
	scriptex3 = isfile("ezsploit\\script3.txt")
	
	local scriptex4 = false
	scriptex4 = isfile("ezsploit\\script4.txt")
	
	local scriptex5 = false
	scriptex5 = isfile("ezsploit\\script5.txt")
	
	local scriptex6 = false
	scriptex6 = isfile("ezsploit\\script6.txt")
	
	local scriptex7 = false
	scriptex7 = isfile("ezsploit\\script6.txt")
	
	if (folderex == false) then
		makefolder("ezsploit")
		writefile("ezsploit\\script.txt", "1")
	end
	
	if (scriptex == false) then
		writefile("ezsploit\\script.txt", "1")
	end
	
	if (scriptex2 == false) then
		writefile("ezsploit\\script2.txt", " ")
	end
	
	if (scriptex3 == false) then
		writefile("ezsploit\\script3.txt", " ")
	end
	
	if (scriptex4 == false) then
		writefile("ezsploit\\script4.txt", " ")
	end
	
	if (scriptex5 == false) then
		writefile("ezsploit\\script5.txt", " ")
	end
	
	if (scriptex6 == false) then
		writefile("ezsploit\\script6.txt", " ")
	end
	
	if (scriptex7 == false) then
		writefile("ezsploit\\script7.txt", " ")
	end
	
	if (scriptex1 == false) then
		writefile("ezsploit\\script1.txt", "Here you can paste your script.")
	end
	
	
	
	local selectedtab = readfile("ezsploit\\script.txt")
	
	if (selectedtab == "1") then
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script1.txt")
		script.Parent.Parent.script1.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
	end
	
	if (selectedtab == "2") then
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script2.txt")
		script.Parent.Parent.script2.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
	end
	
	if (selectedtab == "3") then
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script3.txt")
		script.Parent.Parent.script3.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
	end
	
	if (selectedtab == "4") then
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script4.txt")
		script.Parent.Parent.script4.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
	end
	
	if (selectedtab == "5") then
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script5.txt")
		script.Parent.Parent.script5.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
	end
	
	if (selectedtab == "6") then
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script6.txt")
		script.Parent.Parent.script6.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
	end
	
	if (selectedtab == "7") then
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script7.txt")
		script.Parent.Parent.script7.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
	end
	
	local textBox = script.Parent
	
	local isfocused = false
	
	
	
	local Open1 = true
	
	local UserInputService2 = game:GetService("UserInputService")
	
	UserInputService2.InputBegan:Connect(function(KeyCode)
		if KeyCode.KeyCode == Enum.KeyCode.Insert then 
			if Open1 == true then
				isfocused = true
				Open1 = false
				repeat
					print("EzSploit - AutoSaving.. - Close GUI to stop save(insert)")
					local selectedtab = readfile("ezsploit\\script.txt")
	
					if (selectedtab == "1") then
						writefile("ezsploit\\script1.txt", script.Parent.Parent.TextBox.Text)
					end
	
					if (selectedtab == "2") then
						writefile("ezsploit\\script2.txt", script.Parent.Parent.TextBox.Text)
					end
	
					if (selectedtab == "3") then
						writefile("ezsploit\\script3.txt", script.Parent.Parent.TextBox.Text)
					end
	
					if (selectedtab == "4") then
						writefile("ezsploit\\script4.txt", script.Parent.Parent.TextBox.Text)
					end
	
					if (selectedtab == "5") then
						writefile("ezsploit\\script5.txt", script.Parent.Parent.TextBox.Text)
					end
	
					if (selectedtab == "6") then
						writefile("ezsploit\\script6.txt", script.Parent.Parent.TextBox.Text)
					end
	
					if (selectedtab == "7") then
						writefile("ezsploit\\script7.txt", script.Parent.Parent.TextBox.Text)
					end
					wait(1)
	
				until (isfocused == false)
				
			else
				isfocused = false
				print("EzSploit - Saving Stopped")
				Open1 = true
			end
		end
	end)
	
end
coroutine.wrap(HFZOCZ_fake_script)()
local function SRSTG_fake_script() -- Execute.LocalScript 
	local script = Instance.new('LocalScript', Execute)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
		
		
		loadstring(script.Parent.Parent.TextBox.Text)()
		
	end)
end
coroutine.wrap(SRSTG_fake_script)()
local function GANG_fake_script() -- script1.LocalScript 
	local script = Instance.new('LocalScript', script1)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		writefile("ezsploit\\script.txt", "1")
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script1.txt")
		script.Parent.Parent.script1.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
		script.Parent.Parent.script2.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script3.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script4.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script5.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script6.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script7.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
	end)
end
coroutine.wrap(GANG_fake_script)()
local function LLQCOYP_fake_script() -- script2.LocalScript 
	local script = Instance.new('LocalScript', script2)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		writefile("ezsploit\\script.txt", "2")
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script2.txt")
		script.Parent.Parent.script2.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
		script.Parent.Parent.script1.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script3.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script4.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script5.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script6.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script7.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
	end)
end
coroutine.wrap(LLQCOYP_fake_script)()
local function BEWR_fake_script() -- script3.LocalScript 
	local script = Instance.new('LocalScript', script3)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		writefile("ezsploit\\script.txt", "3")
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script3.txt")
		script.Parent.Parent.script3.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
		script.Parent.Parent.script2.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script1.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script4.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script5.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script6.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script7.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
	end)
end
coroutine.wrap(BEWR_fake_script)()
local function WJAOO_fake_script() -- script4.LocalScript 
	local script = Instance.new('LocalScript', script4)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		writefile("ezsploit\\script.txt", "4")
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script4.txt")
		script.Parent.Parent.script4.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
		script.Parent.Parent.script2.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script3.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script1.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script5.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script6.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script7.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
	end)
end
coroutine.wrap(WJAOO_fake_script)()
local function SBMTTK_fake_script() -- script7.LocalScript 
	local script = Instance.new('LocalScript', script7)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		writefile("ezsploit\\script.txt", "7")
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script7.txt")
		script.Parent.Parent.script7.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
		script.Parent.Parent.script2.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script3.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script4.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script5.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script6.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script1.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
	end)
end
coroutine.wrap(SBMTTK_fake_script)()
local function GTCMMH_fake_script() -- script6.LocalScript 
	local script = Instance.new('LocalScript', script6)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		writefile("ezsploit\\script.txt", "6")
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script6.txt")
		script.Parent.Parent.script6.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
		script.Parent.Parent.script2.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script3.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script4.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script5.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script1.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script7.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
	end)
end
coroutine.wrap(GTCMMH_fake_script)()
local function IOYRT_fake_script() -- script5.LocalScript 
	local script = Instance.new('LocalScript', script5)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		writefile("ezsploit\\script.txt", "5")
		script.Parent.Parent.TextBox.Text = readfile("ezsploit\\script5.txt")
		script.Parent.Parent.script5.BackgroundColor3 = Color3.new(0.337255, 0.337255, 0.337255)
		script.Parent.Parent.script2.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script3.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script4.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script1.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script6.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
		script.Parent.Parent.script7.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)
	end)
end
coroutine.wrap(IOYRT_fake_script)()
local function KMND_fake_script() -- Clear.LocalScript 
	local script = Instance.new('LocalScript', Clear)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
		
		
		script.Parent.Parent.TextBox.Text = ""
		
	end)
end
coroutine.wrap(KMND_fake_script)()
local function RNCG_fake_script() -- FrameSet.LocalScript 
	local script = Instance.new('LocalScript', FrameSet)

	local HWID = game:GetService("RbxAnalyticsService"):GetClientId()
		
	local player = game.Players.LocalPlayer
	
	if player then
		script.Parent.DisplayName.Text = "Display name: "..player.DisplayName..""
		script.Parent.UserName.Text = "Username: "..player.Name..""
		script.Parent.HWID.Text = "Roblox HWID: "..HWID..""
	end
	
	repeat
		if player then
			script.Parent.DisplayName.Text = "Display name: "..player.DisplayName..""
			script.Parent.UserName.Text = "Username: "..player.Name..""
			script.Parent.HWID.Text = "Roblox HWID: "..HWID..""
		end
	until (player)
	
	
end
coroutine.wrap(RNCG_fake_script)()
local function NZWPJDL_fake_script() -- TextButton.LocalScript 
	local script = Instance.new('LocalScript', TextButton)

	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
	
		print(script.Parent.Parent.DisplayName.Text)
		print(script.Parent.Parent.UserName.Text)
		print(script.Parent.Parent.HWID.Text)
	end)
end
coroutine.wrap(NZWPJDL_fake_script)()
local function UAETZEX_fake_script() -- TextButton_2.LocalScript 
	local script = Instance.new('LocalScript', TextButton_2)

	local kkshit = "sex"
	
	local Button = script.Parent
	script.Parent.MouseButton1Click:Connect(function()
		
		kkshit = readfile("ezsploit\\watermark.txt")
	
		if (kkshit == "off") then
			script.Parent.Parent.Parent.Parent.WATERMARK.Visible = true
			writefile("ezsploit\\watermark.txt", "on")
		elseif (kkshit == "on") then
			script.Parent.Parent.Parent.Parent.WATERMARK.Visible = false
			writefile("ezsploit\\watermark.txt", "off")
			
		end
	end)
end
coroutine.wrap(UAETZEX_fake_script)()
local function HMCZSI_fake_script() -- GUIezsploit.LocalScript 
	local script = Instance.new('LocalScript', GUIezsploit)

	script.Parent.Parent.GUIezsploit.ResetOnSpawn = false
	
	
	
	
	script.Parent.WATERMARK.Transparency = 0.8
	script.Parent.WATERMARK.WATERlabel.Transparency = 0.6
	
	local watermark = false
	watermark = isfile("ezsploit\\watermark.txt")
	
	if (watermark == false) then
		writefile("ezsploit\\watermark.txt", "off")
	end
	
	if (readfile("ezsploit\\watermark.txt") == "off") then
		script.Parent.WATERMARK.Visible = false
	elseif (rele("ezsploit\\watermark.txt") == "on") then
		script.Parent.WATERMARK.Visible = true
	end
	
	
	
end
coroutine.wrap(HMCZSI_fake_script)()
