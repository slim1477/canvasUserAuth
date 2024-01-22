import { useState } from "react";
import { Button } from "../ui/button";
import {
  Dialog,
  DialogContent,
  DialogDescription,
  DialogFooter,
  DialogHeader,
  DialogTitle,
  DialogTrigger,
} from "@/components/ui/dialog";

import successIcon from "@/assets/Verification/success.png";
import failIcon from "@/assets/Verification/fail.png";
import { VerificationCode } from "./Code/VerificationCode";

export const VerifyButton = () => {
  const [isVerified, setIsVerified] = useState(false);
  const [isOpen, setIsOpen] = useState(false);
  // state to track if member provided verification code
  const [providedCode, setProvidedCode] = useState<boolean | "indeterminate">(
    false
  );
  const disableVerificationButton = () => {
    if (!providedCode) {
      return true;
    }
    return false;
  };
  const handleVerifyButton = () => {
    setIsVerified(true);
    setIsOpen(false);
  };
  return (
    <>
      <Dialog open={isOpen} onOpenChange={setIsOpen}>
        <DialogTrigger asChild>
          <Button className="h-full w-full border shadow-md bg-background rounded-2xl hover:bg-slate-50">
            <div className="flex gap-2 p-4">
              <p className="text-lg text-black">
                {isVerified ? "Verified" : "Verify"}
              </p>

              {
                <img
                  className="h-6"
                  src={isVerified ? successIcon : failIcon}
                />
              }
            </div>
          </Button>
        </DialogTrigger>
        <DialogContent className="sm:max-w-[425px]">
          <DialogHeader>
            <DialogTitle>Verify Member</DialogTitle>
            <DialogDescription>Using Verification code</DialogDescription>
          </DialogHeader>
          <VerificationCode
            providedCode={providedCode}
            setProvidedCode={setProvidedCode}
          />

          <DialogFooter>
            <Button variant="ghost">Skip</Button>
            <Button
              disabled={disableVerificationButton()}
              className="bg-primary-accent"
              onClick={handleVerifyButton}
            >
              Verify
            </Button>
          </DialogFooter>
        </DialogContent>
      </Dialog>
    </>
  );
};
