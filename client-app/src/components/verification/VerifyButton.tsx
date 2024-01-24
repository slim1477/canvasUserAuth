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
import { PrimaryQuestion } from "./Questions/PrimaryQuestion";
import { itemCounter } from "@/utils/utils";
import Divider from "../Home/Divider";
import { ScrollArea } from "../ui/scroll-area";

export const VerifyButton = () => {
  const [isVerified, setIsVerified] = useState(false);
  const [isOpen, setIsOpen] = useState(false);
  // state to track if member provided verification code
  const [providedCode, setProvidedCode] = useState<boolean | "indeterminate">(
    false
  );
  // disable verify button if there is no verification code or have not answered two primary questions
  const disableVerificationButton = () => {
    if (providedCode || itemCounter(checkedState, true) > 1) {
      return false;
    }

    return true;
  };
  const handleVerifyButton = () => {
    setIsVerified(true);
    setIsOpen(false);
  };

  // Create state to track each checkbox in Primary Questions
  const [checkedState, setCheckedState] = useState(new Array(5).fill(false));

  // function to update checked state array based on array positions
  const handleCheckChange = (position: number) => {
    const updatedCheckState = checkedState.map((item, index) =>
      index === position ? !item : item
    );

    setCheckedState(updatedCheckState);
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
        <DialogContent
          className={"lg:max-w-screen-lg overflow-y-hidden max-h-screen"}
        >
          <DialogHeader>
            <DialogTitle>Verify Member</DialogTitle>
            <DialogDescription>
              Using Verification code or answer primary questions
            </DialogDescription>
          </DialogHeader>
          <ScrollArea className="h-[350px]">
            <section className="flex flex-col gap-6 py-6">
              {/* Verify using code */}
              <VerificationCode
                providedCode={providedCode}
                setProvidedCode={setProvidedCode}
              />
              <Divider />
              {/* Verify by answering account specific questions */}
              <PrimaryQuestion
                checkedState={checkedState}
                handleCheckChange={handleCheckChange}
              />
            </section>
          </ScrollArea>
          <DialogFooter>
            <Button onClick={() => setIsOpen(false)} variant="ghost">
              Close
            </Button>
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
