namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineUpdate : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineUpdate class.
        /// </summary>
        public VirtualMachineUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineUpdate class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="plan">Specifies information about the marketplace
        /// image used to create the virtual machine. This element is only used
        /// for marketplace images. Before you can use a marketplace image from
        /// an API, you must enable the image for programmatic use.  In the
        /// Azure portal, find the marketplace image that you want to use and
        /// then click **Want to deploy programmatically, Get Started -&gt;**.
        /// Enter any required information and then click **Save**.</param>
        /// <param name="hardwareProfile">Specifies the hardware settings for
        /// the virtual machine.</param>
        /// <param name="storageProfile">Specifies the storage settings for the
        /// virtual machine disks.</param>
        /// <param name="additionalCapabilities">Specifies additional
        /// capabilities enabled or disabled on the virtual machine.</param>
        /// <param name="osProfile">Specifies the operating system settings
        /// used while creating the virtual machine. Some of the settings
        /// cannot be changed once VM is provisioned.</param>
        /// <param name="networkProfile">Specifies the network interfaces of
        /// the virtual machine.</param>
        /// <param name="securityProfile">Specifies the Security related
        /// profile settings for the virtual machine.</param>
        /// <param name="diagnosticsProfile">Specifies the boot diagnostic
        /// settings state. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2015-06-15.</param>
        /// <param name="availabilitySet">Specifies information about the
        /// availability set that the virtual machine should be assigned to.
        /// Virtual machines specified in the same availability set are
        /// allocated to different nodes to maximize availability. For more
        /// information about availability sets, see [Manage the availability
        /// of virtual
        /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// &lt;br&gt;&lt;br&gt; For more information on Azure planned
        /// maintenance, see [Planned maintenance for virtual machines in
        /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to
        /// availability set at creation time. The availability set to which
        /// the VM is being added should be under the same resource group as
        /// the availability set resource. An existing VM cannot be added to an
        /// availability set. &lt;br&gt;&lt;br&gt;This property cannot exist
        /// along with a non-null properties.virtualMachineScaleSet
        /// reference.</param>
        /// <param name="virtualMachineScaleSet">Specifies information about
        /// the virtual machine scale set that the virtual machine should be
        /// assigned to. Virtual machines specified in the same virtual machine
        /// scale set are allocated to different nodes to maximize
        /// availability. Currently, a VM can only be added to virtual machine
        /// scale set at creation time. An existing VM cannot be added to a
        /// virtual machine scale set. &lt;br&gt;&lt;br&gt;This property cannot
        /// exist along with a non-null properties.availabilitySet reference.
        /// &lt;br&gt;&lt;br&gt;Minimum api‐version: 2019‐03‐01</param>
        /// <param name="proximityPlacementGroup">Specifies information about
        /// the proximity placement group that the virtual machine should be
        /// assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2018-04-01.</param>
        /// <param name="priority">Specifies the priority for the virtual
        /// machine. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01.
        /// Possible values include: 'Regular', 'Low', 'Spot'</param>
        /// <param name="evictionPolicy">Specifies the eviction policy for the
        /// Azure Spot virtual machine and Azure Spot scale set.
        /// &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both
        /// 'Deallocate' and 'Delete' are supported and the minimum api-version
        /// is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both
        /// 'Deallocate' and 'Delete' are supported and the minimum api-version
        /// is 2017-10-30-preview. Possible values include: 'Deallocate',
        /// 'Delete'</param>
        /// <param name="billingProfile">Specifies the billing related details
        /// of a Azure Spot virtual machine. &lt;br&gt;&lt;br&gt;Minimum
        /// api-version: 2019-03-01.</param>
        /// <param name="host">Specifies information about the dedicated host
        /// that the virtual machine resides in. &lt;br&gt;&lt;br&gt;Minimum
        /// api-version: 2018-10-01.</param>
        /// <param name="hostGroup">Specifies information about the dedicated
        /// host group that the virtual machine resides in.
        /// &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.
        /// &lt;br&gt;&lt;br&gt;NOTE: User cannot specify both host and
        /// hostGroup properties.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="instanceView">The virtual machine instance
        /// view.</param>
        /// <param name="licenseType">Specifies that the image or disk that is
        /// being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible
        /// values for Windows Server operating system are:
        /// &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt;
        /// Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux
        /// Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for
        /// RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE)
        /// &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use
        /// Benefit for Windows
        /// Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing)
        /// &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux
        /// Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux)
        /// &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15</param>
        /// <param name="vmId">Specifies the VM unique ID which is a 128-bits
        /// identifier that is encoded and stored in all Azure IaaS VMs SMBIOS
        /// and can be read using platform BIOS commands.</param>
        /// <param name="extensionsTimeBudget">Specifies the time alloted for
        /// all extensions to start. The time duration should be between 15
        /// minutes and 120 minutes (inclusive) and should be specified in ISO
        /// 8601 format. The default value is 90 minutes (PT1H30M).
        /// &lt;br&gt;&lt;br&gt; Minimum api-version: 2020-06-01</param>
        /// <param name="platformFaultDomain">Specifies the scale set logical
        /// fault domain into which the Virtual Machine will be created. By
        /// default, the Virtual Machine will by automatically assigned to a
        /// fault domain that best maintains balance across available fault
        /// domains.&lt;br&gt;&lt;li&gt;This is applicable only if the
        /// 'virtualMachineScaleSet' property of this Virtual Machine is
        /// set.&lt;li&gt;The Virtual Machine Scale Set that is referenced,
        /// must have 'platformFaultDomainCount' &amp;gt; 1.&lt;li&gt;This
        /// property cannot be updated once the Virtual Machine is
        /// created.&lt;li&gt;Fault domain assignment can be viewed in the
        /// Virtual Machine Instance View.&lt;br&gt;&lt;br&gt;Minimum
        /// api‐version: 2020‐12‐01</param>
        /// <param name="identity">The identity of the virtual machine, if
        /// configured.</param>
        /// <param name="zones">The virtual machine zones.</param>
        public VirtualMachineUpdate(IDictionary<string, string> tags, Plan plan, HardwareProfile hardwareProfile, StorageProfile storageProfile, AdditionalCapabilities additionalCapabilities, OSProfile osProfile, NetworkProfile networkProfile, SecurityProfile securityProfile, DiagnosticsProfile diagnosticsProfile, SubResource availabilitySet, SubResource virtualMachineScaleSet, SubResource proximityPlacementGroup, string priority, string evictionPolicy, BillingProfile billingProfile, SubResource host, SubResource hostGroup, string provisioningState, VirtualMachineInstanceView instanceView , string licenseType, string vmId, string extensionsTimeBudget, VirtualMachineIdentity identity, IList<string> zones)
            : base(tags)
        {
            Plan = plan;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            AdditionalCapabilities = additionalCapabilities;
            OsProfile = osProfile;
            NetworkProfile = networkProfile;
            SecurityProfile = securityProfile;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            VirtualMachineScaleSet = virtualMachineScaleSet;
            ProximityPlacementGroup = proximityPlacementGroup;
            Priority = priority;
            EvictionPolicy = evictionPolicy;
            BillingProfile = billingProfile;
            Host = host;
            HostGroup = hostGroup;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            LicenseType = licenseType;
            VmId = vmId;
            ExtensionsTimeBudget = extensionsTimeBudget;
            PlatformFaultDomain = platformFaultDomain;
            Identity = identity;
            Zones = zones;
            CustomInit();
        }
        
        public VirtualMachineUpdate(IDictionary<string, string> tags, Plan plan, HardwareProfile hardwareProfile, StorageProfile storageProfile, AdditionalCapabilities additionalCapabilities, OSProfile osProfile, NetworkProfile networkProfile, SecurityProfile securityProfile, DiagnosticsProfile diagnosticsProfile, SubResource availabilitySet, SubResource virtualMachineScaleSet, SubResource proximityPlacementGroup, string priority, string evictionPolicy, BillingProfile billingProfile, SubResource host, SubResource hostGroup, string provisioningState, VirtualMachineInstanceView instanceView, string licenseType, string vmId, string extensionsTimeBudget, VirtualMachineIdentity identity)
            : base(tags)
        {
            Plan = plan;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            AdditionalCapabilities = additionalCapabilities;
            OsProfile = osProfile;
            NetworkProfile = networkProfile;
            SecurityProfile = securityProfile;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            VirtualMachineScaleSet = virtualMachineScaleSet;
            ProximityPlacementGroup = proximityPlacementGroup;
            Priority = priority;
            EvictionPolicy = evictionPolicy;
            BillingProfile = billingProfile;
            Host = host;
            HostGroup = hostGroup;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            LicenseType = licenseType;
            VmId = vmId;
            ExtensionsTimeBudget = extensionsTimeBudget;
            PlatformFaultDomain = platformFaultDomain;
            Identity = identity;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the hardware settings for the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the storage settings for the virtual machine
        /// disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies additional capabilities enabled or disabled
        /// on the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalCapabilities")]
        public AdditionalCapabilities AdditionalCapabilities { get; set; }

        /// <summary>
        /// Gets or sets specifies the operating system settings used while
        /// creating the virtual machine. Some of the settings cannot be
        /// changed once VM is provisioned.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osProfile")]
        public OSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the network interfaces of the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkProfile")]
        public NetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the Security related profile settings for
        /// the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the boot diagnostic settings state.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2015-06-15.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the availability set that
        /// the virtual machine should be assigned to. Virtual machines
        /// specified in the same availability set are allocated to different
        /// nodes to maximize availability. For more information about
        /// availability sets, see [Manage the availability of virtual
        /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For more information on Azure
        /// planned maintenance, see [Planned maintenance for virtual machines
        /// in
        /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Currently, a VM can only be
        /// added to availability set at creation time. The availability set to
        /// which the VM is being added should be under the same resource group
        /// as the availability set resource. An existing VM cannot be added to
        /// an availability set. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;This
        /// property cannot exist along with a non-null
        /// properties.virtualMachineScaleSet reference.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilitySet")]
        public SubResource AvailabilitySet { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the virtual machine scale
        /// set that the virtual machine should be assigned to. Virtual
        /// machines specified in the same virtual machine scale set are
        /// allocated to different nodes to maximize availability. Currently, a
        /// VM can only be added to virtual machine scale set at creation time.
        /// An existing VM cannot be added to a virtual machine scale set.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;This property cannot exist
        /// along with a non-null properties.availabilitySet reference.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api‐version: 2019‐03‐01
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineScaleSet")]
        public SubResource VirtualMachineScaleSet { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the proximity placement
        /// group that the virtual machine should be assigned to.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2018-04-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.proximityPlacementGroup")]
        public SubResource ProximityPlacementGroup { get; set; }

        /// <summary>
        /// Gets or sets specifies the priority for the virtual machine.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2019-03-01. Possible values include: 'Regular', 'Low', 'Spot'
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or sets specifies the eviction policy for the Azure Spot
        /// virtual machine and Azure Spot scale set.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;For Azure Spot virtual
        /// machines, both 'Deallocate' and 'Delete' are supported and the
        /// minimum api-version is 2019-03-01.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;For Azure Spot scale sets, both
        /// 'Deallocate' and 'Delete' are supported and the minimum api-version
        /// is 2017-10-30-preview. Possible values include: 'Deallocate',
        /// 'Delete'
        /// </summary>
        [JsonProperty(PropertyName = "properties.evictionPolicy")]
        public string EvictionPolicy { get; set; }

        /// <summary>
        /// Gets or sets specifies the billing related details of a Azure Spot
        /// virtual machine. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum
        /// api-version: 2019-03-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfile")]
        public BillingProfile BillingProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the dedicated host that
        /// the virtual machine resides in.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2018-10-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.host")]
        public SubResource Host { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the dedicated host group
        /// that the virtual machine resides in.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2020-06-01. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;NOTE: User cannot
        /// specify both host and hostGroup properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostGroup")]
        public SubResource HostGroup { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the virtual machine instance view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets or sets specifies that the image or disk that is being used
        /// was licensed on-premises. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// Possible values for Windows Server operating system are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Windows_Client
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Windows_Server
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values for Linux
        /// Server operating system are: &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// RHEL_BYOS (for RHEL) &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; SLES_BYOS
        /// (for SUSE) &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For more
        /// information, see [Azure Hybrid Use Benefit for Windows
        /// Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing)
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; [Azure Hybrid Use Benefit for
        /// Linux
        /// Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux)
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Minimum api-version:
        /// 2015-06-15
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets specifies the VM unique ID which is a 128-bits identifier that
        /// is encoded and stored in all Azure IaaS VMs SMBIOS and can be read
        /// using platform BIOS commands.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmId")]
        public string VmId { get; private set; }

        /// <summary>
        /// Gets or sets specifies the time alloted for all extensions to
        /// start. The time duration should be between 15 minutes and 120
        /// minutes (inclusive) and should be specified in ISO 8601 format. The
        /// default value is 90 minutes (PT1H30M).
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Minimum api-version:
        /// 2020-06-01
        /// </summary>
        [JsonProperty(PropertyName = "properties.extensionsTimeBudget")]
        public string ExtensionsTimeBudget { get; set; }

        /// <summary>
        /// Gets or sets specifies the scale set logical fault domain into
        /// which the Virtual Machine will be created. By default, the Virtual
        /// Machine will by automatically assigned to a fault domain that best
        /// maintains balance across available fault
        /// domains.&amp;lt;br&amp;gt;&amp;lt;li&amp;gt;This is applicable only
        /// if the 'virtualMachineScaleSet' property of this Virtual Machine is
        /// set.&amp;lt;li&amp;gt;The Virtual Machine Scale Set that is
        /// referenced, must have 'platformFaultDomainCount' &amp;amp;gt;
        /// 1.&amp;lt;li&amp;gt;This property cannot be updated once the
        /// Virtual Machine is created.&amp;lt;li&amp;gt;Fault domain
        /// assignment can be viewed in the Virtual Machine Instance
        /// View.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api‐version:
        /// 2020‐12‐01
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformFaultDomain")]
        public int? PlatformFaultDomain { get; set; }

        /// <summary>
        /// Gets or sets the identity of the virtual machine, if configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public VirtualMachineIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine zones.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageProfile != null)
            {
                StorageProfile.Validate();
            }
        }
    }
}
