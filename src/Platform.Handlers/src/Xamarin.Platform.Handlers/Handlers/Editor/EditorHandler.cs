﻿namespace Xamarin.Platform.Handlers
{
	public partial class EditorHandler
	{
		public static PropertyMapper<IEditor, EditorHandler> EditorMapper = new PropertyMapper<IEditor, EditorHandler>(ViewHandler.ViewMapper)
		{
			[nameof(IEditor.Text)] = MapText,
			[nameof(IEditor.TextColor)] = MapTextColor
		};

		public EditorHandler() : base(EditorMapper)
		{

		}

		public EditorHandler(PropertyMapper mapper) : base(mapper ?? EditorMapper)
		{

		}
	}
}