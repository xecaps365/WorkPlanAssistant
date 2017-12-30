using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace JobPlanMakerAssistant
{

    class CReadDataFromFileBase
    { 
    
       String m_fileName; //include file path
       List<CDataHKNJH> m_DataHKNJH;
    
    }
   
						



    struct CDataHKNJH
    {
       //  线别
       //  专业	
       //  设备名称
       //  设备数量
       //  数量单位	
       // 上次检修时间	
       // 检修周期
       //


        Int64 JobNo;
        String jobName;
        String jobPlace;
        DateTime jobPlanStartTime;
        DateTime jobPlanEndTime;
        String jobDoer;
        String strReqSource;
    }
    
    
    
    
    class CReadDataFromFile
    {
        String m_fileName; //include file path

        List<CDataKTZY> m_DataKTZY;

        List<CDataPSZY> m_DataPSZY;

        List<CDataDYZY> m_DataDYZY;

        List<CDataXGZY> m_DataXGZY;

    }



    struct CDataKTZY 
    {
        Int64 JobNo;
        String jobName;
        String jobPlace;
        DateTime jobPlanStartTime;
        DateTime jobPlanEndTime;
        String jobDoer;
        String strReqSource;
    }

    struct CDataPSZY
    {
        Int64 JobNo;
        String jobName;
        String jobPlace;
        DateTime jobPlanStartTime;
        DateTime jobPlanEndTime;
        String jobDoer;
        String strReqSource;
    }

    struct CDataDYZY
    {
        Int64 JobNo;
        String jobName;
        String jobPlace;
        DateTime jobPlanStartTime;
        DateTime jobPlanEndTime;
        String jobDoer;
        String strReqSource;
    }

    struct CDataXGZY
    {
        Int64 JobNo;
        String jobName;
        String jobPlace;
        DateTime jobPlanStartTime;
        DateTime jobPlanEndTime;
        String jobDoer;
        String strReqSource;
    }


    struct CYearPlanDataKTZY
    {
        Int64 JobNo;
        String jobName;
        String jobPlace;
        DateTime jobPlanStartTime;
        DateTime jobPlanEndTime;
        String jobDoer;
        String strReqSource;
    }

    struct CYearPlanDataPSZY
    {
        Int64 JobNo;
        String jobName;
        String jobPlace;
        DateTime jobPlanStartTime;
        DateTime jobPlanEndTime;
        String jobDoer;
        String strReqSource;
    }

    struct CYearPlanDataDYZY
    {
        Int64 JobNo;
        String jobName;
        String jobPlace;
        DateTime jobPlanStartTime;
        DateTime jobPlanEndTime;
        String jobDoer;
        String strReqSource;
    }



}
