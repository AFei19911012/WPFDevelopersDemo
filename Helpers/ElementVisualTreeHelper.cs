using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using MessageBox = WPFDevelopers.Controls.MessageBox;

namespace WPFDevelopersDemo.Helpers
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @CoderMan/CoderMan1012 2023 All rights reserved
    /// Author      : CoderMan/CoderMan1012
    /// Created Time: 2023/2/9 23:07:20
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time              Modified By                               Modified Content
    /// V1.0.0.0     2023/2/9 23:07:20    CoderMan/CoderMan1012                 
    ///
    public class ElementVisualTreeHelper
    {
        /// <summary>
        ///     利用visualtreehelper寻找对象的子级对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<T> FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            try
            {
                var TList = new List<T>();
                for (var i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    var child = VisualTreeHelper.GetChild(obj, i);
                    if (child != null && child is T)
                    {
                        TList.Add((T)child);
                        var childOfChildren = FindVisualChild<T>(child);
                        if (childOfChildren != null) TList.AddRange(childOfChildren);
                    }
                    else
                    {
                        var childOfChildren = FindVisualChild<T>(child);
                        if (childOfChildren != null) TList.AddRange(childOfChildren);
                    }
                }

                return TList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }
    }
}