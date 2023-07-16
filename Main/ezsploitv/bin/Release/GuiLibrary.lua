local UserInputService = game:GetService("UserInputService")

local ScreenGui = Instance.new("ScreenGui")
local Blatant = Instance.new("Frame")
local Blatanttab = Instance.new("ScrollingFrame")
local UIListLayout = Instance.new("UIListLayout")
local Frame = Instance.new("Frame")
local ImageLabel = Instance.new("ImageLabel")
local TextLabel = Instance.new("TextLabel")
local Combat = Instance.new("Frame")
local Combattab = Instance.new("ScrollingFrame")
local UIListLayout_2 = Instance.new("UIListLayout")
local Frame_2 = Instance.new("Frame")
local ImageLabel_2 = Instance.new("ImageLabel")
local TextLabel_2 = Instance.new("TextLabel")
local Visual = Instance.new("Frame")
local Visualtab = Instance.new("ScrollingFrame")
local UIListLayout_3 = Instance.new("UIListLayout")
local Frame_3 = Instance.new("Frame")
local TextLabel_3 = Instance.new("TextLabel")
local ImageLabel_3 = Instance.new("ImageLabel")
local World = Instance.new("Frame")
local Worldtab = Instance.new("ScrollingFrame")
local UIListLayout_4 = Instance.new("UIListLayout")
local Frame_4 = Instance.new("Frame")
local ImageLabel_4 = Instance.new("ImageLabel")
local TextLabel_4 = Instance.new("TextLabel")
local Misc = Instance.new("Frame")
local Misctab = Instance.new("ScrollingFrame")
local UIListLayout_5 = Instance.new("UIListLayout")
local Frame_5 = Instance.new("Frame")
local TextLabel_5 = Instance.new("TextLabel")
local ImageLabel_5 = Instance.new("ImageLabel")

--Properties:

ScreenGui.Parent = game.Players.LocalPlayer:WaitForChild("PlayerGui")
ScreenGui.ZIndexBehavior = Enum.ZIndexBehavior.Sibling
ScreenGui.ResetOnSpawn = false
Blatant.Name = "Blatant"
Blatant.Parent = ScreenGui
Blatant.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Blatant.BackgroundTransparency = 1.000
Blatant.BorderColor3 = Color3.fromRGB(255, 0, 0)
Blatant.Position = UDim2.new(0.149460703, 0, 0.185785532, 0)
Blatant.Size = UDim2.new(0, 172, 0, 309)

Blatanttab.Name = "Blatanttab"
Blatanttab.Parent = Blatant
Blatanttab.Active = true
Blatanttab.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
Blatanttab.BorderColor3 = Color3.fromRGB(0, 0, 0)
Blatanttab.BorderSizePixel = 0
Blatanttab.Position = UDim2.new(0, 0, 0.110032365, 0)
Blatanttab.Size = UDim2.new(0, 172, 0, 275)

UIListLayout.Parent = Blatanttab
UIListLayout.SortOrder = Enum.SortOrder.LayoutOrder

Frame.Parent = Blatant
Frame.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Frame.BorderColor3 = Color3.fromRGB(0, 0, 0)
Frame.BorderSizePixel = 0
Frame.Size = UDim2.new(0, 172, 0, 34)

ImageLabel.Parent = Frame
ImageLabel.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
ImageLabel.BackgroundTransparency = 1.000
ImageLabel.BorderColor3 = Color3.fromRGB(0, 0, 0)
ImageLabel.BorderSizePixel = 0
ImageLabel.Position = UDim2.new(0.802325606, 0, 0.00323624606, 0)
ImageLabel.Size = UDim2.new(0, 34, 0, 33)
ImageLabel.Image = "rbxassetid://13800390062"
ImageLabel.ImageColor3 = Color3.fromRGB(200, 0, 0)

TextLabel.Parent = Frame
TextLabel.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
TextLabel.BackgroundTransparency = 1.000
TextLabel.BorderColor3 = Color3.fromRGB(0, 0, 0)
TextLabel.BorderSizePixel = 0
TextLabel.Size = UDim2.new(0, 172, 0, 34)
TextLabel.Font = Enum.Font.SourceSans
TextLabel.Text = "  Blatant"
TextLabel.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel.TextSize = 14.000
TextLabel.TextXAlignment = Enum.TextXAlignment.Left

Combat.Name = "Combat"
Combat.Parent = ScreenGui
Combat.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Combat.BackgroundTransparency = 1.000
Combat.BorderColor3 = Color3.fromRGB(255, 0, 0)
Combat.Position = UDim2.new(0.289676428, 0, 0.185785532, 0)
Combat.Size = UDim2.new(0, 172, 0, 309)

Combattab.Name = "Combattab"
Combattab.Parent = Combat
Combattab.Active = true
Combattab.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
Combattab.BorderColor3 = Color3.fromRGB(0, 0, 0)
Combattab.BorderSizePixel = 0
Combattab.Position = UDim2.new(0, 0, 0.110032365, 0)
Combattab.Size = UDim2.new(0, 172, 0, 275)

UIListLayout_2.Parent = Combattab
UIListLayout_2.SortOrder = Enum.SortOrder.LayoutOrder

Frame_2.Parent = Combat
Frame_2.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Frame_2.BorderColor3 = Color3.fromRGB(0, 0, 0)
Frame_2.BorderSizePixel = 0
Frame_2.Size = UDim2.new(0, 172, 0, 34)

ImageLabel_2.Parent = Frame_2
ImageLabel_2.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
ImageLabel_2.BackgroundTransparency = 1.000
ImageLabel_2.BorderColor3 = Color3.fromRGB(0, 0, 0)
ImageLabel_2.BorderSizePixel = 0
ImageLabel_2.Position = UDim2.new(0.813953459, 0, 0.00647249212, 0)
ImageLabel_2.Size = UDim2.new(0, 32, 0, 32)
ImageLabel_2.Image = "rbxassetid://13799913671"
ImageLabel_2.ImageColor3 = Color3.fromRGB(200, 0, 0)

TextLabel_2.Parent = Frame_2
TextLabel_2.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_2.BackgroundTransparency = 1.000
TextLabel_2.BorderColor3 = Color3.fromRGB(0, 0, 0)
TextLabel_2.BorderSizePixel = 0
TextLabel_2.Size = UDim2.new(0, 172, 0, 34)
TextLabel_2.Font = Enum.Font.SourceSans
TextLabel_2.Text = "  Combat"
TextLabel_2.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_2.TextSize = 14.000
TextLabel_2.TextXAlignment = Enum.TextXAlignment.Left

Visual.Name = "Visual"
Visual.Parent = ScreenGui
Visual.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Visual.BackgroundTransparency = 1.000
Visual.BorderColor3 = Color3.fromRGB(255, 0, 0)
Visual.Position = UDim2.new(0.433744222, 0, 0.185785532, 0)
Visual.Size = UDim2.new(0, 172, 0, 309)

Visualtab.Name = "Visualtab"
Visualtab.Parent = Visual
Visualtab.Active = true
Visualtab.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
Visualtab.BorderColor3 = Color3.fromRGB(0, 0, 0)
Visualtab.BorderSizePixel = 0
Visualtab.Position = UDim2.new(0, 0, 0.110032365, 0)
Visualtab.Size = UDim2.new(0, 172, 0, 275)

UIListLayout_3.Parent = Visualtab
UIListLayout_3.SortOrder = Enum.SortOrder.LayoutOrder

Frame_3.Parent = Visual
Frame_3.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Frame_3.BorderColor3 = Color3.fromRGB(0, 0, 0)
Frame_3.BorderSizePixel = 0
Frame_3.Size = UDim2.new(0, 172, 0, 34)

TextLabel_3.Parent = Frame_3
TextLabel_3.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_3.BackgroundTransparency = 1.000
TextLabel_3.BorderColor3 = Color3.fromRGB(0, 0, 0)
TextLabel_3.BorderSizePixel = 0
TextLabel_3.Size = UDim2.new(0, 172, 0, 34)
TextLabel_3.Font = Enum.Font.SourceSans
TextLabel_3.Text = "  Visual"
TextLabel_3.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_3.TextSize = 14.000
TextLabel_3.TextXAlignment = Enum.TextXAlignment.Left

ImageLabel_3.Parent = Frame_3
ImageLabel_3.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
ImageLabel_3.BackgroundTransparency = 1.000
ImageLabel_3.BorderColor3 = Color3.fromRGB(0, 0, 0)
ImageLabel_3.BorderSizePixel = 0
ImageLabel_3.Position = UDim2.new(0.802325606, 0, 0, 0)
ImageLabel_3.Size = UDim2.new(0, 34, 0, 34)
ImageLabel_3.Image = "rbxassetid://13800409501"
ImageLabel_3.ImageColor3 = Color3.fromRGB(200, 0, 0)

World.Name = "World"
World.Parent = ScreenGui
World.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
World.BackgroundTransparency = 1.000
World.BorderColor3 = Color3.fromRGB(255, 0, 0)
World.Position = UDim2.new(0.577812016, 0, 0.185785532, 0)
World.Size = UDim2.new(0, 172, 0, 309)

Worldtab.Name = "Worldtab"
Worldtab.Parent = World
Worldtab.Active = true
Worldtab.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
Worldtab.BorderColor3 = Color3.fromRGB(0, 0, 0)
Worldtab.BorderSizePixel = 0
Worldtab.Position = UDim2.new(0, 0, 0.110032365, 0)
Worldtab.Size = UDim2.new(0, 172, 0, 275)

UIListLayout_4.Parent = Worldtab
UIListLayout_4.SortOrder = Enum.SortOrder.LayoutOrder

Frame_4.Parent = World
Frame_4.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Frame_4.BorderColor3 = Color3.fromRGB(0, 0, 0)
Frame_4.BorderSizePixel = 0
Frame_4.Size = UDim2.new(0, 172, 0, 34)

ImageLabel_4.Parent = Frame_4
ImageLabel_4.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
ImageLabel_4.BackgroundTransparency = 1.000
ImageLabel_4.BorderColor3 = Color3.fromRGB(0, 0, 0)
ImageLabel_4.BorderSizePixel = 0
ImageLabel_4.Position = UDim2.new(0.790697694, 0, 0, 0)
ImageLabel_4.Size = UDim2.new(0, 36, 0, 34)
ImageLabel_4.Image = "rbxassetid://13988608911"
ImageLabel_4.ImageColor3 = Color3.fromRGB(200, 0, 0)

TextLabel_4.Parent = Frame_4
TextLabel_4.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_4.BackgroundTransparency = 1.000
TextLabel_4.BorderColor3 = Color3.fromRGB(0, 0, 0)
TextLabel_4.BorderSizePixel = 0
TextLabel_4.Size = UDim2.new(0, 172, 0, 34)
TextLabel_4.Font = Enum.Font.SourceSans
TextLabel_4.Text = "  World"
TextLabel_4.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_4.TextSize = 14.000
TextLabel_4.TextXAlignment = Enum.TextXAlignment.Left

Misc.Name = "Misc"
Misc.Parent = ScreenGui
Misc.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Misc.BackgroundTransparency = 1.000
Misc.BorderColor3 = Color3.fromRGB(255, 0, 0)
Misc.Position = UDim2.new(0.72265029, 0, 0.185785532, 0)
Misc.Size = UDim2.new(0, 172, 0, 309)

Misctab.Name = "Misctab"
Misctab.Parent = Misc
Misctab.Active = true
Misctab.BackgroundColor3 = Color3.fromRGB(20, 20, 20)
Misctab.BorderColor3 = Color3.fromRGB(0, 0, 0)
Misctab.BorderSizePixel = 0
Misctab.Position = UDim2.new(0, 0, 0.110032365, 0)
Misctab.Size = UDim2.new(0, 172, 0, 275)

UIListLayout_5.Parent = Misctab
UIListLayout_5.SortOrder = Enum.SortOrder.LayoutOrder

Frame_5.Parent = Misc
Frame_5.BackgroundColor3 = Color3.fromRGB(10, 10, 10)
Frame_5.BorderColor3 = Color3.fromRGB(0, 0, 0)
Frame_5.BorderSizePixel = 0
Frame_5.Size = UDim2.new(0, 172, 0, 34)

TextLabel_5.Parent = Frame_5
TextLabel_5.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_5.BackgroundTransparency = 1.000
TextLabel_5.BorderColor3 = Color3.fromRGB(0, 0, 0)
TextLabel_5.BorderSizePixel = 0
TextLabel_5.Size = UDim2.new(0, 172, 0, 34)
TextLabel_5.Font = Enum.Font.SourceSans
TextLabel_5.Text = "  Misc"
TextLabel_5.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel_5.TextSize = 14.000
TextLabel_5.TextXAlignment = Enum.TextXAlignment.Left

ImageLabel_5.Parent = Frame_5
ImageLabel_5.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
ImageLabel_5.BackgroundTransparency = 1.000
ImageLabel_5.BorderColor3 = Color3.fromRGB(0, 0, 0)
ImageLabel_5.BorderSizePixel = 0
ImageLabel_5.Position = UDim2.new(0.802325606, 0, 0, 0)
ImageLabel_5.Size = UDim2.new(0, 34, 0, 34)
ImageLabel_5.Image = "rbxassetid://13800287778"
ImageLabel_5.ImageColor3 = Color3.fromRGB(200, 0, 0)

function MakeToggle(tab, text, dzwontyl) --TAB LIST: Combattab, Blatanttab, Visualtab, Misctab, Worldtab
	local button = Instance.new("TextButton")
	local toggle = false
	button.Name = "button"
	button.Parent = tab
	button.BackgroundColor3 = Color3.fromRGB(30, 30, 30)
	button.BorderColor3 = Color3.fromRGB(0, 0, 0)
	button.BorderSizePixel = 0
	button.Size = UDim2.new(0, 206, 0, 23)
	button.Text = "  "..text
	button.Font = Enum.Font.SourceSans
	button.TextColor3 = Color3.fromRGB(255, 255, 255)
	button.TextSize = 20.000
	button.TextXAlignment = "Left"
    
	button.MouseButton1Click:Connect(function()
		if toggle  then
			button.BackgroundColor3 = Color3.fromRGB(30, 30, 30)
			toggle = not toggle
		else
			toggle = not toggle
			button.BackgroundColor3 = Color3.fromRGB(211, 0, 0)
		end
		loadstring(dzwontyl)()
	end)
    if isfile(text) then
		if readfile(text) == "on" then
			writefile(text, "off")
			toggle = true
			button.BackgroundColor3 = Color3.fromRGB(211, 0, 0)
            loadstring(dzwontyl)()
		else
			toggle = false
		end
	end
end


function istoggled(name, value)
	if isfile(name) then
	else
		if value then
			writefile(name, "on")
		else
			writefile(name, "off")
		end
	end
end

local function IKXOZUW_fake_script() -- Blatant.TabSet 
	local script = Instance.new('LocalScript', Blatant)

	local UserInputService = game:GetService("UserInputService")
	local runService = (game:GetService("RunService"));
	
	local gui = script.Parent
	
	local dragging
	local dragInput
	local dragStart
	local startPos
	
	function Lerp(a, b, m)
		return a + (b - a) * m
	end;
	
	local lastMousePos
	local lastGoalPos
	local DRAG_SPEED = (12); -- // The speed of the UI darg.
	function Update(dt)
		if not (startPos) then return end;
		if not (dragging) and (lastGoalPos) then
			gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, lastGoalPos.X.Offset, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, lastGoalPos.Y.Offset, dt * DRAG_SPEED))
			return 
		end;
	
		local delta = (lastMousePos - UserInputService:GetMouseLocation())
		local xGoal = (startPos.X.Offset - delta.X);
		local yGoal = (startPos.Y.Offset - delta.Y);
		lastGoalPos = UDim2.new(startPos.X.Scale, xGoal, startPos.Y.Scale, yGoal)
		gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, xGoal, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, yGoal, dt * DRAG_SPEED))
	end;
	
	gui.InputBegan:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseButton1 or input.UserInputType == Enum.UserInputType.Touch then
			dragging = true
			dragStart = input.Position
			startPos = gui.Position
			lastMousePos = UserInputService:GetMouseLocation()
	
			input.Changed:Connect(function()
				if input.UserInputState == Enum.UserInputState.End then
					dragging = false
				end
			end)
		end
	end)
	
	gui.InputChanged:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseMovement or input.UserInputType == Enum.UserInputType.Touch then
			dragInput = input
		end
	end)
	runService.Heartbeat:Connect(Update)
	
	
end
coroutine.wrap(IKXOZUW_fake_script)()
local function NRXSV_fake_script() -- Frame.LocalScript 
	local script = Instance.new('LocalScript', Frame)

	local InsideFrame = false
	script.Parent.MouseEnter:Connect(function()
		InsideFrame = true
	end)
	
	script.Parent.MouseLeave:Connect(function()
		InsideFrame = false
	end)
	
	
	script.Parent.InputBegan:Connect(function(input)
		if InsideFrame then
			if input.UserInputType == Enum.UserInputType.MouseButton2 then
				script.Parent.Parent.Blatanttab.Visible = not script.Parent.Parent.Blatanttab.Visible
			end
		end
		
	end)
end
coroutine.wrap(NRXSV_fake_script)()
local function DFKO_fake_script() -- Combat.TabSet 
	local script = Instance.new('LocalScript', Combat)

	local UserInputService = game:GetService("UserInputService")
	local runService = (game:GetService("RunService"));
	
	local gui = script.Parent
	
	local dragging
	local dragInput
	local dragStart
	local startPos
	
	function Lerp(a, b, m)
		return a + (b - a) * m
	end;
	
	local lastMousePos
	local lastGoalPos
	local DRAG_SPEED = (12); -- // The speed of the UI darg.
	function Update(dt)
		if not (startPos) then return end;
		if not (dragging) and (lastGoalPos) then
			gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, lastGoalPos.X.Offset, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, lastGoalPos.Y.Offset, dt * DRAG_SPEED))
			return 
		end;
	
		local delta = (lastMousePos - UserInputService:GetMouseLocation())
		local xGoal = (startPos.X.Offset - delta.X);
		local yGoal = (startPos.Y.Offset - delta.Y);
		lastGoalPos = UDim2.new(startPos.X.Scale, xGoal, startPos.Y.Scale, yGoal)
		gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, xGoal, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, yGoal, dt * DRAG_SPEED))
	end;
	
	gui.InputBegan:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseButton1 or input.UserInputType == Enum.UserInputType.Touch then
			dragging = true
			dragStart = input.Position
			startPos = gui.Position
			lastMousePos = UserInputService:GetMouseLocation()
	
			input.Changed:Connect(function()
				if input.UserInputState == Enum.UserInputState.End then
					dragging = false
				end
			end)
		end
	end)
	
	gui.InputChanged:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseMovement or input.UserInputType == Enum.UserInputType.Touch then
			dragInput = input
		end
	end)
	runService.Heartbeat:Connect(Update)
	
	
end
coroutine.wrap(DFKO_fake_script)()
local function OPYM_fake_script() -- Frame_2.LocalScript 
	local script = Instance.new('LocalScript', Frame_2)

	local InsideFrame = false
	script.Parent.MouseEnter:Connect(function()
		InsideFrame = true
	end)
	
	script.Parent.MouseLeave:Connect(function()
		InsideFrame = false
	end)
	
	
	script.Parent.InputBegan:Connect(function(input)
		if InsideFrame then
			if input.UserInputType == Enum.UserInputType.MouseButton2 then
				script.Parent.Parent.Combattab.Visible = not script.Parent.Parent.Combattab.Visible
			end
		end
	
	end)
end
coroutine.wrap(OPYM_fake_script)()
local function PBOS_fake_script() -- Visual.TabSet 
	local script = Instance.new('LocalScript', Visual)

	local UserInputService = game:GetService("UserInputService")
	local runService = (game:GetService("RunService"));
	
	local gui = script.Parent
	
	local dragging
	local dragInput
	local dragStart
	local startPos
	
	function Lerp(a, b, m)
		return a + (b - a) * m
	end;
	
	local lastMousePos
	local lastGoalPos
	local DRAG_SPEED = (12); -- // The speed of the UI darg.
	function Update(dt)
		if not (startPos) then return end;
		if not (dragging) and (lastGoalPos) then
			gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, lastGoalPos.X.Offset, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, lastGoalPos.Y.Offset, dt * DRAG_SPEED))
			return 
		end;
	
		local delta = (lastMousePos - UserInputService:GetMouseLocation())
		local xGoal = (startPos.X.Offset - delta.X);
		local yGoal = (startPos.Y.Offset - delta.Y);
		lastGoalPos = UDim2.new(startPos.X.Scale, xGoal, startPos.Y.Scale, yGoal)
		gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, xGoal, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, yGoal, dt * DRAG_SPEED))
	end;
	
	gui.InputBegan:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseButton1 or input.UserInputType == Enum.UserInputType.Touch then
			dragging = true
			dragStart = input.Position
			startPos = gui.Position
			lastMousePos = UserInputService:GetMouseLocation()
	
			input.Changed:Connect(function()
				if input.UserInputState == Enum.UserInputState.End then
					dragging = false
				end
			end)
		end
	end)
	
	gui.InputChanged:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseMovement or input.UserInputType == Enum.UserInputType.Touch then
			dragInput = input
		end
	end)
	runService.Heartbeat:Connect(Update)
	
	
end
coroutine.wrap(PBOS_fake_script)()
local function BQGB_fake_script() -- Frame_3.LocalScript 
	local script = Instance.new('LocalScript', Frame_3)

	local InsideFrame = false
	script.Parent.MouseEnter:Connect(function()
		InsideFrame = true
	end)
	
	script.Parent.MouseLeave:Connect(function()
		InsideFrame = false
	end)
	
	
	script.Parent.InputBegan:Connect(function(input)
		if InsideFrame then
			if input.UserInputType == Enum.UserInputType.MouseButton2 then
				script.Parent.Parent.Visualtab.Visible = not script.Parent.Parent.Visualtab.Visible
			end
		end
	
	end)
end
coroutine.wrap(BQGB_fake_script)()
local function JEEM_fake_script() -- World.TabSet 
	local script = Instance.new('LocalScript', World)

	local UserInputService = game:GetService("UserInputService")
	local runService = (game:GetService("RunService"));
	
	local gui = script.Parent
	
	local dragging
	local dragInput
	local dragStart
	local startPos
	
	function Lerp(a, b, m)
		return a + (b - a) * m
	end;
	
	local lastMousePos
	local lastGoalPos
	local DRAG_SPEED = (12); -- // The speed of the UI darg.
	function Update(dt)
		if not (startPos) then return end;
		if not (dragging) and (lastGoalPos) then
			gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, lastGoalPos.X.Offset, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, lastGoalPos.Y.Offset, dt * DRAG_SPEED))
			return 
		end;
	
		local delta = (lastMousePos - UserInputService:GetMouseLocation())
		local xGoal = (startPos.X.Offset - delta.X);
		local yGoal = (startPos.Y.Offset - delta.Y);
		lastGoalPos = UDim2.new(startPos.X.Scale, xGoal, startPos.Y.Scale, yGoal)
		gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, xGoal, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, yGoal, dt * DRAG_SPEED))
	end;
	
	gui.InputBegan:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseButton1 or input.UserInputType == Enum.UserInputType.Touch then
			dragging = true
			dragStart = input.Position
			startPos = gui.Position
			lastMousePos = UserInputService:GetMouseLocation()
	
			input.Changed:Connect(function()
				if input.UserInputState == Enum.UserInputState.End then
					dragging = false
				end
			end)
		end
	end)
	
	gui.InputChanged:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseMovement or input.UserInputType == Enum.UserInputType.Touch then
			dragInput = input
		end
	end)
	runService.Heartbeat:Connect(Update)
	
	
end
coroutine.wrap(JEEM_fake_script)()
local function EMXHDW_fake_script() -- Frame_4.LocalScript 
	local script = Instance.new('LocalScript', Frame_4)

	local InsideFrame = false
	script.Parent.MouseEnter:Connect(function()
		InsideFrame = true
	end)
	
	script.Parent.MouseLeave:Connect(function()
		InsideFrame = false
	end)
	
	
	script.Parent.InputBegan:Connect(function(input)
		if InsideFrame then
			if input.UserInputType == Enum.UserInputType.MouseButton2 then
				script.Parent.Parent.Worldtab.Visible = not script.Parent.Parent.Worldtab.Visible
			end
		end
	
	end)
end
coroutine.wrap(EMXHDW_fake_script)()
local function LDNWCY_fake_script() -- Misc.TabSet 
	local script = Instance.new('LocalScript', Misc)

	local UserInputService = game:GetService("UserInputService")
	local runService = (game:GetService("RunService"));
	
	local gui = script.Parent
	
	local dragging
	local dragInput
	local dragStart
	local startPos
	
	function Lerp(a, b, m)
		return a + (b - a) * m
	end;
	
	local lastMousePos
	local lastGoalPos
	local DRAG_SPEED = (12); -- // The speed of the UI darg.
	function Update(dt)
		if not (startPos) then return end;
		if not (dragging) and (lastGoalPos) then
			gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, lastGoalPos.X.Offset, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, lastGoalPos.Y.Offset, dt * DRAG_SPEED))
			return 
		end;
	
		local delta = (lastMousePos - UserInputService:GetMouseLocation())
		local xGoal = (startPos.X.Offset - delta.X);
		local yGoal = (startPos.Y.Offset - delta.Y);
		lastGoalPos = UDim2.new(startPos.X.Scale, xGoal, startPos.Y.Scale, yGoal)
		gui.Position = UDim2.new(startPos.X.Scale, Lerp(gui.Position.X.Offset, xGoal, dt * DRAG_SPEED), startPos.Y.Scale, Lerp(gui.Position.Y.Offset, yGoal, dt * DRAG_SPEED))
	end;
	
	gui.InputBegan:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseButton1 or input.UserInputType == Enum.UserInputType.Touch then
			dragging = true
			dragStart = input.Position
			startPos = gui.Position
			lastMousePos = UserInputService:GetMouseLocation()
	
			input.Changed:Connect(function()
				if input.UserInputState == Enum.UserInputState.End then
					dragging = false
				end
			end)
		end
	end)
	
	gui.InputChanged:Connect(function(input)
		if input.UserInputType == Enum.UserInputType.MouseMovement or input.UserInputType == Enum.UserInputType.Touch then
			dragInput = input
		end
	end)
	runService.Heartbeat:Connect(Update)
	
	
end
coroutine.wrap(LDNWCY_fake_script)()
local function KLSV_fake_script() -- Frame_5.LocalScript 
	local script = Instance.new('LocalScript', Frame_5)

	local InsideFrame = false
	script.Parent.MouseEnter:Connect(function()
		InsideFrame = true
	end)
	
	script.Parent.MouseLeave:Connect(function()
		InsideFrame = false
	end)
	
	
	script.Parent.InputBegan:Connect(function(input)
		if InsideFrame then
			if input.UserInputType == Enum.UserInputType.MouseButton2 then
				script.Parent.Parent.Misctab.Visible = not script.Parent.Parent.Misctab.Visible
			end
		end
	
	end)
end
coroutine.wrap(KLSV_fake_script)()
local function OLLLEVL_fake_script() -- ScreenGui.LocalScript 
	local script = Instance.new('LocalScript', ScreenGui)

	UserInputService.InputBegan:Connect(function(KeyCode)
		if KeyCode.KeyCode == Enum.KeyCode.Insert then 
			script.Parent.Blatant.Visible = not script.Parent.Blatant.Visible
			script.Parent.Combat.Visible = not script.Parent.Combat.Visible
			script.Parent.Visual.Visible = not script.Parent.Visual.Visible
			script.Parent.World.Visible = not script.Parent.World.Visible
			script.Parent.Misc.Visible = not script.Parent.Misc.Visible
		end
	end)
end
coroutine.wrap(OLLLEVL_fake_script)()


--EXAMPLE TOGGLE BUTTON:
istoggled("example button", false)
MakeToggle(Combattab, "example button", [[
	if readfile("example button") == "on" then
		writefile("example button", "off")
	
		print("HERE PASTE YOUR SCRIPT ON TURN OFF")                
	else
		writefile("example button", "on")
	
		print("HERE PASTE YOUR SCRIPT ON TURN ON")
	end
]])

--EXAMPLE TOGGLE BUTTON WITH REPEAT (THATS IMPORTANT TO DO 'until' METHOD WITH 'readfile("ModuleName")'):
istoggled("Speed", false)
MakeToggle(Worldtab, "Speed", [[
	if readfile("Speed") == "on" then
		writefile("Speed", "off")
        game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 16
		              
	else
		writefile("Speed", "on")
        repeat
		    game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 23
            wait()
        until readfile("Speed") == "off"
	end
]])