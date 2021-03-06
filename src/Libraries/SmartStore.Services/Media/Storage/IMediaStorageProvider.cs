﻿using SmartStore.Core.Plugins;

namespace SmartStore.Services.Media.Storage
{
	public interface IMediaStorageProvider : IProvider
	{
		/// <summary>
		/// Load media item data
		/// </summary>
		/// <param name="media">Media storage item</param>
		byte[] Load(MediaItem media);

		/// <summary>
		/// Save media item data
		/// </summary>
		/// <param name="media">Media storage item</param>
		/// <param name="data">New binary data</param>
		void Save(MediaItem media, byte[] data);

		/// <summary>
		/// Remove media storage item(s)
		/// </summary>
		/// <param name="medias">Media storage items</param>
		void Remove(params MediaItem[] medias);
	}
}
