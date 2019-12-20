﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidXamarin.Data.Data;
using AndroidXamarin.Data.Models;
using AndroidXamarin.Resources;

//nuGet packages:
    //downloaded:
        //For splashScreen:
        //Xamarin.Android.Support.v4
        //Xamarin.Android.Support.v7.AppCompat 

    //not downloaded:
        //To make gridview work well on older devices, install nuGet package:
        //xamarin.android.suppord.v7.gridLayout

namespace AndroidXamarin.Activities
{
    [Activity(Label = "LogInFormActivity"/*, MainLauncher = true*/)]
    public class LogInFormActivity : Activity
    {

        ListView list_view;
        SelectUserFormAdapter adapter;
        public static ObservableCollection<UserItem> list_source { get; set; }
        Button add_user;
        string username;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LogInForm);
            //ListView Id bugged
            list_view = FindViewById<ListView>(Resource.Id.login_list);
            add_user = FindViewById<Button>(Resource.Id.login_add);
            list_source = new ObservableCollection<UserItem>();
            adapter = new SelectUserFormAdapter(this, list_source);

            #region
            /*
                confirm.Click += (s, e) =>
                {
                    user_exsists = false;
                    username = input.Text;

                    foreach (UserItem user in list_source)
                    {
                        if (username == user.name)
                        {
                            user_exsists = true;
                            break;
                        }
                    }

                    if (user_exsists)
                    {
                        Intent main_menu_activity = new Intent(this, typeof(MainMenuFormActivity));
                        StartActivity(main_menu_activity);
                    } else
                    {
                        input.Text = "NOT FOUND";
                    }
                };
            */
            #endregion

            add_user.Click += (s, e) =>
            {
                Intent create_user_activity = new Intent(this, typeof(CreateNewUserFormActivity));
                StartActivityForResult(create_user_activity, 0);
            };

            // adding mock data
            DataTable data = UsersDataTable.GetTable();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                /*
                   byte[] myImage = (byte[])  myDataSet.Tables["TableName"].RowsNo["ImageColumnName"];
                   To get the same value from a datareader :
                   byte[] myImage = (byte[])  reader.GetValue(0);
                   To obtain an image from the byte array use this code:
                   MemoryStream ms = new MemoryStream(myImage);
                   Bitmap mybmp = new Bitmap(ms);
                    */
                User user = new User();
                user.name = data.Rows[i]["name"].ToString();
                user.refPhoto = Converter.ObjectToByteArray(data.Rows[i]["refPhoto"]);
                user.hasRefPhoto = Convert.ToInt32(data.Rows[i]["hasRefPhoto"]);

                UserItem userItem = new UserItem();
                userItem.name = user.name;
                userItem.refPhoto = user.refPhoto;
                if (user.hasRefPhoto == 0)
                    userItem.has_ref_photo = false;
                else
                    userItem.has_ref_photo = true;
                list_source.Add(userItem);
            }
            
            list_view.Adapter = adapter;
            list_view.ItemClick += userListOnItemClick;
        }

        private void userListOnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //Not using ref photo
            CurrentUser.name = list_source[e.Position].name;
            CurrentUser.has_ref_photo = list_source[e.Position].has_ref_photo;

            Intent main_menu_activity = new Intent(this, typeof(MainMenuFormActivity));
            StartActivity(main_menu_activity);

            //Using ref photo
            //if (CurrentUser.has_ref_photo == false)
            //{
            //    Intent upload_ref = new Intent(this, typeof(MainActivity));
            //    StartActivity(upload_ref);
            //}
            //else
            //{
            //Intent upload_ref_activity = new Intent(this, typeof(MainActivity));
            //StartActivity(upload_ref_activity);
            //}
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                UserItem new_user = new UserItem()
                {
                    name = username = data.GetStringExtra("name"),
                    has_ref_photo = false
                };

                list_source.Add(new_user);

                //adapter = new SelectUserFormAdapter(this, list_source);
                list_view.Adapter = adapter;
                list_view.ItemClick += userListOnItemClick;
            }
        }
    }
}