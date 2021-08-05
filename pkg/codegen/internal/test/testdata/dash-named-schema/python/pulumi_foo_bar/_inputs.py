# coding=utf-8
# *** WARNING: this file was generated by test. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'TopLevelArgs',
]

@pulumi.input_type
class TopLevelArgs:
    def __init__(__self__, *,
                 buzz: Optional[pulumi.Input[str]] = None):
        if buzz is not None:
            pulumi.set(__self__, "buzz", buzz)

    @property
    @pulumi.getter
    def buzz(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "buzz")

    @buzz.setter
    def buzz(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "buzz", value)


