﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWinYouTube
{

   // This is from the JIRA T-Mobile Schema used by Eamon's team.
#pragma warning disable IDE1006 // Naming Styles
   class JIRA_INFUOPSCS
   {




      public class Rootobject
      {
         public string expand { get; set; }
         public int startAt { get; set; }
         public int maxResults { get; set; }
         public int total { get; set; }
         public Issue[] issues { get; set; }
      }

      public class Issue
      {
         public string expand { get; set; }
         public string id { get; set; }
         public string self { get; set; }
         public string key { get; set; }
         public Fields fields { get; set; }
      }

      public class Fields
      {
         public object customfield_17700 { get; set; }
         public object customfield_12133 { get; set; }
         public object customfield_12012 { get; set; }
         public object customfield_12136 { get; set; }
         public object resolution { get; set; }
         public object customfield_12138 { get; set; }
         public object customfield_12137 { get; set; }
         public object customfield_17701 { get; set; }
         public object customfield_12008 { get; set; }
         public object customfield_10500 { get; set; }
         public object customfield_12007 { get; set; }
         public object customfield_12804 { get; set; }
         public object customfield_24000 { get; set; }
         public object customfield_24001 { get; set; }
         public object customfield_24002 { get; set; }
         public DateTime? lastViewed { get; set; }
         public object customfield_12004 { get; set; }
         public object customfield_12124 { get; set; }
         public object customfield_12006 { get; set; }
         public object[] labels { get; set; }
         public object customfield_12005 { get; set; }
         public object customfield_12118 { get; set; }
         public object customfield_12119 { get; set; }
         public object customfield_11704 { get; set; }
         public object aggregatetimeoriginalestimate { get; set; }
         public object[] issuelinks { get; set; }
         public object assignee { get; set; }
         public object customfield_25900 { get; set; }
         public object[] components { get; set; }
         public object customfield_17000 { get; set; }
         public float customfield_12112 { get; set; }
         public object customfield_12116 { get; set; }
         public object customfield_12107 { get; set; }
         public object customfield_12106 { get; set; }
         public object customfield_12109 { get; set; }
         public object customfield_12108 { get; set; }
         public object[] subtasks { get; set; }
         public Reporter reporter { get; set; }
         public object customfield_12105 { get; set; }
         public object customfield_12104 { get; set; }
         public object customfield_11920 { get; set; }
         public object customfield_11921 { get; set; }
         public object customfield_11924 { get; set; }
         public object customfield_11926 { get; set; }
         public object customfield_11925 { get; set; }
         public object customfield_11928 { get; set; }
         public object customfield_11927 { get; set; }
         public Progress progress { get; set; }
         public object customfield_25003 { get; set; }
         public Votes votes { get; set; }
         public object customfield_11929 { get; set; }
         public Issuetype issuetype { get; set; }
         public object customfield_17102 { get; set; }
         public Customfield_17101 customfield_17101 { get; set; }
         public Customfield_17100 customfield_17100 { get; set; }
         public Project project { get; set; }
         public object customfield_11000 { get; set; }
         public string customfield_17104 { get; set; }
         public object customfield_17103 { get; set; }
         public object customfield_12213 { get; set; }
         public object customfield_12212 { get; set; }
         public object customfield_12215 { get; set; }
         public object customfield_12214 { get; set; }
         public object customfield_12205 { get; set; }
         public float customfield_11911 { get; set; }
         public object customfield_11910 { get; set; }
         public object customfield_11913 { get; set; }
         public float customfield_11912 { get; set; }
         public object customfield_11915 { get; set; }
         public object resolutiondate { get; set; }
         public object customfield_11914 { get; set; }
         public object customfield_11917 { get; set; }
         public object customfield_11919 { get; set; }
         public object customfield_11918 { get; set; }
         public object customfield_26900 { get; set; }
         public Watches watches { get; set; }
         public object customfield_10020 { get; set; }
         public object customfield_10021 { get; set; }
         public object customfield_10022 { get; set; }
         public object customfield_12204 { get; set; }
         public object customfield_10016 { get; set; }
         public object customfield_10017 { get; set; }
         public object customfield_10018 { get; set; }
         public string customfield_10019 { get; set; }
         public object customfield_11904 { get; set; }
         public object customfield_11906 { get; set; }
         public object customfield_11908 { get; set; }
         public object customfield_11907 { get; set; }
         public object customfield_23400 { get; set; }
         public DateTime updated { get; set; }
         public object customfield_23401 { get; set; }
         public object customfield_19500 { get; set; }
         public object timeoriginalestimate { get; set; }
         public string description { get; set; }
         public object customfield_10010 { get; set; }
         public object customfield_10011 { get; set; }
         public object customfield_11100 { get; set; }
         public object customfield_10012 { get; set; }
         public object customfield_10013 { get; set; }
         public object customfield_10014 { get; set; }
         public object customfield_14610 { get; set; }
         public object customfield_10015 { get; set; }
         public object customfield_14611 { get; set; }
         public string customfield_10005 { get; set; }
         public object customfield_12305 { get; set; }
         public object customfield_14605 { get; set; }
         public object customfield_10006 { get; set; }
         public object customfield_12304 { get; set; }
         public object customfield_14606 { get; set; }
         public object customfield_16904 { get; set; }
         public Customfield_10007 customfield_10007 { get; set; }
         public string customfield_10008 { get; set; }
         public string customfield_10009 { get; set; }
         public object customfield_14609 { get; set; }
         public object customfield_16909 { get; set; }
         public object customfield_16908 { get; set; }
         public object customfield_14607 { get; set; }
         public object customfield_16907 { get; set; }
         public object customfield_14608 { get; set; }
         public string summary { get; set; }
         public object customfield_10000 { get; set; }
         public object customfield_10001 { get; set; }
         public object customfield_10002 { get; set; }
         public object customfield_10003 { get; set; }
         public object customfield_10004 { get; set; }
         public object customfield_10115 { get; set; }
         public object environment { get; set; }
         public object duedate { get; set; }
         public object customfield_21004 { get; set; }
         public object customfield_21002 { get; set; }
         public object customfield_15000 { get; set; }
         public object[] fixVersions { get; set; }
         public object customfield_10110 { get; set; }
         public object customfield_10111 { get; set; }
         public string customfield_11200 { get; set; }
         public object customfield_10112 { get; set; }
         public object customfield_10113 { get; set; }
         public object customfield_10114 { get; set; }
         public object customfield_10104 { get; set; }
         public object customfield_10106 { get; set; }
         public object customfield_10107 { get; set; }
         public object customfield_10108 { get; set; }
         public object customfield_10900 { get; set; }
         public object customfield_10109 { get; set; }
         public object customfield_10904 { get; set; }
         public object customfield_10905 { get; set; }
         public object customfield_10906 { get; set; }
         public Priority priority { get; set; }
         public object customfield_10100 { get; set; }
         public object[] customfield_10101 { get; set; }
         public object customfield_10102 { get; set; }
         public object customfield_10103 { get; set; }
         public object customfield_29300 { get; set; }
         public object timeestimate { get; set; }
         public object[] versions { get; set; }
         public object customfield_29301 { get; set; }
         public object customfield_29304 { get; set; }
         public object customfield_29305 { get; set; }
         public object customfield_29302 { get; set; }
         public object customfield_29303 { get; set; }
         public object customfield_29308 { get; set; }
         public object customfield_29309 { get; set; }
         public object customfield_29306 { get; set; }
         public object customfield_29307 { get; set; }
         public Status status { get; set; }
         public object customfield_10203 { get; set; }
         public object customfield_10204 { get; set; }
         public object customfield_10205 { get; set; }
         public object customfield_12505 { get; set; }
         public object customfield_10206 { get; set; }
         public object customfield_12504 { get; set; }
         public object customfield_10207 { get; set; }
         public object customfield_12507 { get; set; }
         public object customfield_28101 { get; set; }
         public object aggregatetimeestimate { get; set; }
         public object customfield_10208 { get; set; }
         public object customfield_12506 { get; set; }
         public object customfield_28102 { get; set; }
         public object customfield_10209 { get; set; }
         public object customfield_28100 { get; set; }
         public object customfield_28105 { get; set; }
         public object customfield_28106 { get; set; }
         public object customfield_28103 { get; set; }
         public object customfield_28104 { get; set; }
         public object customfield_28107 { get; set; }
         public object customfield_28900 { get; set; }
         public Creator creator { get; set; }
         public object customfield_14004 { get; set; }
         public Aggregateprogress aggregateprogress { get; set; }
         public object customfield_10200 { get; set; }
         public object customfield_10201 { get; set; }
         public object customfield_10202 { get; set; }
         public object customfield_16304 { get; set; }
         public string customfield_29201 { get; set; }
         public string customfield_29202 { get; set; }
         public string customfield_29200 { get; set; }
         public string customfield_29203 { get; set; }
         public object customfield_12170 { get; set; }
         public object customfield_12172 { get; set; }
         public object customfield_12171 { get; set; }
         public object customfield_14110 { get; set; }
         public object customfield_12174 { get; set; }
         public object timespent { get; set; }
         public object customfield_12173 { get; set; }
         public object customfield_12176 { get; set; }
         public object customfield_14113 { get; set; }
         public object customfield_12175 { get; set; }
         public object customfield_14114 { get; set; }
         public object customfield_12178 { get; set; }
         public object customfield_14111 { get; set; }
         public object customfield_12177 { get; set; }
         public object customfield_14112 { get; set; }
         public object customfield_14117 { get; set; }
         public object aggregatetimespent { get; set; }
         public object customfield_12179 { get; set; }
         public object customfield_14118 { get; set; }
         public object customfield_15204 { get; set; }
         public object customfield_10302 { get; set; }
         public object customfield_10303 { get; set; }
         public object customfield_12604 { get; set; }
         public object customfield_14108 { get; set; }
         public object customfield_10304 { get; set; }
         public object customfield_14109 { get; set; }
         public string customfield_28002 { get; set; }
         public Customfield_28003 customfield_28003 { get; set; }
         public string customfield_28000 { get; set; }
         public string customfield_28001 { get; set; }
         public int workratio { get; set; }
         public object customfield_12161 { get; set; }
         public object customfield_12160 { get; set; }
         public object customfield_12163 { get; set; }
         public DateTime created { get; set; }
         public object customfield_12162 { get; set; }
         public object customfield_12165 { get; set; }
         public object customfield_12164 { get; set; }
         public object customfield_12167 { get; set; }
         public object customfield_16400 { get; set; }
         public object customfield_12166 { get; set; }
         public object customfield_12169 { get; set; }
         public object customfield_14106 { get; set; }
         public object customfield_12168 { get; set; }
         public object customfield_14107 { get; set; }
         public object customfield_10300 { get; set; }
         public object customfield_14104 { get; set; }
         public object customfield_10301 { get; set; }
         public object customfield_14105 { get; set; }
         public object customfield_23800 { get; set; }
         public object customfield_23801 { get; set; }
         public object customfield_23802 { get; set; }
         public object customfield_12150 { get; set; }
         public object customfield_23803 { get; set; }
         public object customfield_23804 { get; set; }
         public object customfield_12152 { get; set; }
         public object customfield_12151 { get; set; }
         public object customfield_12154 { get; set; }
         public object customfield_12153 { get; set; }
         public object customfield_12156 { get; set; }
         public object customfield_12155 { get; set; }
         public object customfield_12158 { get; set; }
         public object customfield_12157 { get; set; }
         public object customfield_12159 { get; set; }
         public object customfield_10403 { get; set; }
         public float customfield_12704 { get; set; }
         public object customfield_12141 { get; set; }
         public object customfield_12140 { get; set; }
         public object customfield_12143 { get; set; }
         public object customfield_12142 { get; set; }
         public object customfield_16500 { get; set; }
         public object customfield_12145 { get; set; }
         public object customfield_12144 { get; set; }
         public object customfield_12147 { get; set; }
         public object customfield_12146 { get; set; }
         public object customfield_12149 { get; set; }
         public object customfield_12148 { get; set; }
         public object customfield_12139 { get; set; }
      }

      public class Reporter
      {
         public string self { get; set; }
         public string name { get; set; }
         public string key { get; set; }
         public string emailAddress { get; set; }
         public Avatarurls avatarUrls { get; set; }
         public string displayName { get; set; }

         public bool active { get; set; }
         public string timeZone { get; set; }
      }

      public class Avatarurls
      {
         public string _48x48 { get; set; }
         public string _24x24 { get; set; }
         public string _16x16 { get; set; }
         public string _32x32 { get; set; }
      }

      public class Progress
      {
         public int progress { get; set; }
         public int total { get; set; }
      }

      public class Votes
      {
         public string self { get; set; }
         public int votes { get; set; }
         public bool hasVoted { get; set; }
      }

      public class Issuetype
      {
         public string self { get; set; }
         public string id { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public bool subtask { get; set; }
      }

      public class Customfield_17101
      {
         public string self { get; set; }
         public string value { get; set; }
         public string id { get; set; }
      }

      public class Customfield_17100
      {
         public string self { get; set; }
         public string value { get; set; }
         public string id { get; set; }
      }

      public class Project
      {
         public string self { get; set; }
         public string id { get; set; }
         public string key { get; set; }
         public string name { get; set; }
         public Avatarurls1 avatarUrls { get; set; }
      }

      public class Avatarurls1
      {
         public string _48x48 { get; set; }
         public string _24x24 { get; set; }
         public string _16x16 { get; set; }
         public string _32x32 { get; set; }
      }

      public class Watches
      {
         public string self { get; set; }
         public int watchCount { get; set; }
         public bool isWatching { get; set; }
      }

      public class Customfield_10007
      {
         public string self { get; set; }
         public string value { get; set; }
         public string id { get; set; }
      }

      public class Priority
      {
         public string self { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
      }

      public class Status
      {
         public string self { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
         public Statuscategory statusCategory { get; set; }
      }

      public class Statuscategory
      {
         public string self { get; set; }
         public int id { get; set; }
         public string key { get; set; }
         public string colorName { get; set; }
         public string name { get; set; }
      }

      public class Creator
      {
         public string self { get; set; }
         public string name { get; set; }
         public string key { get; set; }
         public string emailAddress { get; set; }
         public Avatarurls2 avatarUrls { get; set; }
         public string displayName { get; set; }
         public bool active { get; set; }
         public string timeZone { get; set; }
      }

      public class Avatarurls2
      {
         public string _48x48 { get; set; }
         public string _24x24 { get; set; }
         public string _16x16 { get; set; }
         public string _32x32 { get; set; }
      }

      public class Aggregateprogress
      {
         public int progress { get; set; }
         public int total { get; set; }
      }

      public class Customfield_28003
      {
         public string self { get; set; }
         public string value { get; set; }
         public string id { get; set; }
      }
#pragma warning restore IDE1006 // Naming Styles
   }
}
