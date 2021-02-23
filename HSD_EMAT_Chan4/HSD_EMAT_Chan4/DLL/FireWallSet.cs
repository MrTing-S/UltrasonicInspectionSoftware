namespace HSD_EMAT_Chan4.DLL
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Security.Principal;
    using Microsoft.Win32;
    using NetFwTypeLib;

    public class FirewallSet
    {
        /// <summary>
        /// 判断程序是否拥有管理员权限
        /// </summary>
        /// <returns>true:是管理员；false:不是管理员</returns>
        public static bool IsAdministrator()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        /// <summary>
        /// 通过注册表操作防火墙
        /// </summary>
        /// <param name="domainState">域网络防火墙（禁用：0；启用（默认）：1）</param>
        /// <param name="publicState">公共网络防火墙（禁用：0；启用（默认）：1）</param>
        /// <param name="standardState">专用网络防火墙（禁用：0；启用（默认）：1）</param>
        /// <returns></returns>
        public static bool FirewallOperateByRegistryKey(int domainState = 1, int publicState = 1, int standardState = 1)
        {
            RegistryKey key = Registry.LocalMachine;
            try
            {
                string path = "HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\SharedAccess\\Defaults\\FirewallPolicy";
                RegistryKey firewall = key.OpenSubKey(path, true);
                RegistryKey domainProfile = firewall.OpenSubKey("DomainProfile", true);
                RegistryKey publicProfile = firewall.OpenSubKey("PublicProfile", true);
                RegistryKey standardProfile = firewall.OpenSubKey("StandardProfile", true);
                domainProfile.SetValue("EnableFirewall", domainState, RegistryValueKind.DWord);
                publicProfile.SetValue("EnableFirewall", publicState, RegistryValueKind.DWord);
                standardProfile.SetValue("EnableFirewall", standardState, RegistryValueKind.DWord);
            }
            catch (Exception e)
            {
                string error = $"注册表修改出错：{e.Message}";
                throw new Exception(error);
            }
            return true;
        }

        /// <summary>
        /// 通过对象防火墙操作
        /// </summary>
        /// <param name="isOpenDomain">域网络防火墙（禁用：false；启用（默认）：true）</param>
        /// <param name="isOpenPublicState">公共网络防火墙（禁用：false；启用（默认）：true）</param>
        /// <param name="isOpenStandard">专用网络防火墙（禁用: false；启用（默认）：true）</param>
        /// <returns></returns>
        public static bool FirewallOperateByObject(bool isOpenDomain = true, bool isOpenPublicState = true, bool isOpenStandard = true)
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                // 启用<高级安全Windows防火墙> - 专有配置文件的防火墙
                firewallPolicy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE, isOpenStandard);
                // 启用<高级安全Windows防火墙> - 公用配置文件的防火墙
                firewallPolicy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC, isOpenPublicState);
                // 启用<高级安全Windows防火墙> - 域配置文件的防火墙
                firewallPolicy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_DOMAIN, isOpenDomain);
            }
            catch (Exception e)
            {
                string error = $"防火墙修改出错：{e.Message}";
                //throw new Exception(error);
                System.Windows.Forms.MessageBox.Show(error);
                return false;
            }
            return true;
        }
    }
}
