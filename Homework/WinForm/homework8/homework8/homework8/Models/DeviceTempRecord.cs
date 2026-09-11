using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace homework8.Models
{
    internal class DeviceTempRecord:INotifyPropertyChanged//属性改变 通知接口，数据变了 自动告诉界面刷新显示
    {
        public event PropertyChangedEventHandler PropertyChanged;//定义属性改变 事件
        private DateTime _CollectTime;

        public DateTime CollectTime
        {
            get
            {
                return _CollectTime;
            }
            set
            {
                _CollectTime = value;
                //触发 属性改变事件 ，通知绑定系统 CollectTime这个属性 改变了，刷新界面
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CollectTime)));
            }

        }
        private ushort _DeviceStatus;

        public ushort DeviceStatus
        {
            get
            {
                return _DeviceStatus;
            }
            set
            {
                _DeviceStatus = value;
                //触发 属性改变事件 ，通知绑定系统 DeviceStatus这个属性 改变了，刷新界面
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DeviceStatus)));
            }

        }
        private ushort _SetTemp;

        public ushort SetTemp
        {
            get
            {
                return _SetTemp;
            }
            set
            {
                _SetTemp = value;
                //触发 属性改变事件 ，通知绑定系统 SetTemp这个属性 改变了，刷新界面
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SetTemp)));
            }

        }
        private ushort _RealTemp;

        public ushort RealTemp//单词 real是 （真实的） 的意思
        {
            get
            {
                return _RealTemp;
            }
            set
            {
                _RealTemp = value;
                //触发 属性改变事件 ，通知绑定系统 RealTemp这个属性 改变了，刷新界面
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RealTemp)));
            }

        }
        private ushort _FaultCode;//故障码 的意思

        public ushort FaultCode//单词 real是 （真实的） 的意思
        {
            get
            {
                return _FaultCode;
            }
            set
            {
                _FaultCode = value;
                //触发 属性改变事件 ，通知绑定系统 FaultCode这个属性 改变了，刷新界面
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FaultCode)));
            }

        }

        public DeviceTempRecord(ushort[] DTR)
        {
            CollectTime = DateTime.Now;//collect 采集
            DeviceStatus = DTR[0];
            SetTemp = DTR[1];
            RealTemp = DTR[2];
            FaultCode = DTR[3];
        }



    }
}
