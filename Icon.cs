using Godot;
using System;

public partial class Icon : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var viewportSize = new Vector2(
			ProjectSettings.GetSetting("display/window/size/viewport_width").AsSingle(),
			ProjectSettings.GetSetting("display/window/size/viewport_height").AsSingle());

		this.Position = viewportSize / 2;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
