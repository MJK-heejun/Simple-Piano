using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Media;
using System.Collections.Generic;
using Android.Content.PM;
using Android.Widget;

namespace SimplePiano
{
	[Activity (Label = "Simple Piano", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Landscape)]
	[IntentFilter(new[] { Intent.ActionView },
		Categories = new[] {
			Intent.CategoryDefault,
			Intent.CategoryBrowsable
		},
		DataScheme = "http",
		DataHost = "example.com"
	)]
	public class SimplePiano : Activity
	{
        List<MediaPlayer> _pianoKeys;

        protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.main);


            _pianoKeys = new List<MediaPlayer> {
                MediaPlayer.Create(this, Resource.Raw.c),
                MediaPlayer.Create(this, Resource.Raw.d),
                MediaPlayer.Create(this, Resource.Raw.e),
                MediaPlayer.Create(this, Resource.Raw.f),
                MediaPlayer.Create(this, Resource.Raw.g),
                MediaPlayer.Create(this, Resource.Raw.h),
                MediaPlayer.Create(this, Resource.Raw.i),
                MediaPlayer.Create(this, Resource.Raw.c2)
            };

            setViewAndSound();

        }


        private void setViewAndSound()
        {
            var imgKeyC = FindViewById<ImageView>(Resource.Id.key_c);
            imgKeyC.SetImageResource(Resource.Drawable.c);
            imgKeyC.Click += delegate
            {
                if (_pianoKeys[0].IsPlaying)
                    _pianoKeys[0].SeekTo(0);
                else
                    _pianoKeys[0].Start();
            };

            var imgKeyD = FindViewById<ImageView>(Resource.Id.key_d);
            imgKeyD.SetImageResource(Resource.Drawable.d);
            imgKeyD.Click += delegate
            {
                if (_pianoKeys[1].IsPlaying)
                    _pianoKeys[1].SeekTo(0);
                else
                    _pianoKeys[1].Start();
            };

            var imgKeyE = FindViewById<ImageView>(Resource.Id.key_e);
            imgKeyE.SetImageResource(Resource.Drawable.e);
            imgKeyE.Click += delegate
            {
                if (_pianoKeys[2].IsPlaying)
                    _pianoKeys[2].SeekTo(0);
                else
                    _pianoKeys[2].Start();
            };


            var imgKeyF = FindViewById<ImageView>(Resource.Id.key_f);
            imgKeyF.SetImageResource(Resource.Drawable.f);
            imgKeyF.Click += delegate
            {
                if (_pianoKeys[3].IsPlaying)
                    _pianoKeys[3].SeekTo(0);
                else
                    _pianoKeys[3].Start();
            };


            var imgKeyG = FindViewById<ImageView>(Resource.Id.key_g);
            imgKeyG.SetImageResource(Resource.Drawable.g);
            imgKeyG.Click += delegate
            {
                if (_pianoKeys[4].IsPlaying)
                    _pianoKeys[4].SeekTo(0);
                else
                    _pianoKeys[4].Start();
            };


            var imgKeyH = FindViewById<ImageView>(Resource.Id.key_h);
            imgKeyH.SetImageResource(Resource.Drawable.h);
            imgKeyH.Click += delegate
            {
                if (_pianoKeys[5].IsPlaying)
                    _pianoKeys[5].SeekTo(0);
                else
                    _pianoKeys[5].Start();
            };


            var imgKeyI = FindViewById<ImageView>(Resource.Id.key_i);
            imgKeyI.SetImageResource(Resource.Drawable.i);
            imgKeyI.Click += delegate
            {
                if (_pianoKeys[6].IsPlaying)
                    _pianoKeys[6].SeekTo(0);
                else
                    _pianoKeys[6].Start();
            };


            var imgKeyC2 = FindViewById<ImageView>(Resource.Id.key_c2);
            imgKeyC2.SetImageResource(Resource.Drawable.c2);
            imgKeyC2.Click += delegate
            {
                if (_pianoKeys[7].IsPlaying)
                    _pianoKeys[7].SeekTo(0);
                else
                    _pianoKeys[7].Start();
            };
        }

    }
}
